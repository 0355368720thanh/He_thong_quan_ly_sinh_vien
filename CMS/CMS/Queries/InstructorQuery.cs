using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CMS.Queries
{
    internal class InstructorQuery
    {
        public void GetAllDataInstructor(ListView listviewIns)
        {
            string sql = "select * from Instructors where DeletedAt is null";
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!listviewIns.Items.ContainsKey(reader["InstructorID"].ToString()))
                    {
                        var itemInstructor = listviewIns.Items.Add(reader["InstructorID"].ToString());
                        itemInstructor.SubItems.Add(reader["FullName"].ToString());
                        itemInstructor.SubItems.Add(reader["Gender"].ToString());
                        itemInstructor.SubItems.Add(reader["Email"].ToString());
                        itemInstructor.SubItems.Add(reader["Birthday"].ToString());
                        itemInstructor.SubItems.Add(reader["Phone"].ToString());
                        itemInstructor.SubItems.Add(reader["Address"].ToString());
                        itemInstructor.SubItems.Add(reader["Specialized"].ToString());
                        itemInstructor.SubItems.Add(reader["CreatedAt"].ToString());
                        itemInstructor.SubItems.Add(reader["UpdatedAt"].ToString());

                    }
                }
                conn.Close();
            }
        }
        public int InsertInstructor(string FullName, string Gender, string Email, string Birthday, string Phone, string Address, string Specialized)
        {
            string sqlInsert = "INSERT INTO Instructors(FullName,Gender,Email,Birthday,Phone,Address,Specialized,CreatedAt) VALUES(@FullName,@Gender,@Email,@Birthday,@Phone,@Address,@Specialized,@CreatedAt) SELECT SCOPE_IDENTITY()";
            // select scope_identity(): lay ra duoc Id vua dc insert
            int lastInsertId = 0;
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                // kiem tra du lieu dau vao 
                cmd.Parameters.AddWithValue("@FullName", FullName ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Gender", Gender ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Email", Email ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Birthday", Birthday ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Phone", Phone ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Address", Address ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Specialized", Specialized ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                lastInsertId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            return lastInsertId;
        }
        public bool UpdateInstructor(int InstructorID, string FullName, string Gender, string Email, string Birthday, string Phone, string Address, string Specialized)
        {
            string sqlUpdate = "UPDATE Instructors SET FullName=@FullName,Gender=@Gender,Email=@Email,Birthday=@Birthday,Phone=@Phone,Address=@Address,Specialized=@Specialized, UpdatedAt=@UpdatedAt WHERE InstructorID=@InstructorID";
            bool checkUpdate = false;
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                cmd.Parameters.AddWithValue("@InstructorID", InstructorID);
                cmd.Parameters.AddWithValue("@FullName", FullName ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Gender", Gender ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Email", Email ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Birthday", Birthday ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Phone", Phone ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Address", Address ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Specialized", Specialized ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                conn.Close();
                checkUpdate = true;

            }
            return checkUpdate;
        }
        public bool DeleteInstructorID(int InstructorID)
        {
            string sqlStr = "UPDATE Instructors SET DeletedAt = @DeletedAt WHERE InstructorID= @InstructorID ";
            bool checkDeleted = false;
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@DeletedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("@InstructorID", InstructorID);
                cmd.ExecuteNonQuery();
                conn.Close();
                checkDeleted = true;
            }
            return checkDeleted;

        }
    }
}


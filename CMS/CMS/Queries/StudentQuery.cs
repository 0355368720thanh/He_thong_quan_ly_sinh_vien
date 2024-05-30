using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CMS.Queries
{
    internal class StudentQuery
    {
        public void GetAllDataStudent(ListView listviewStu)
        {
            string sql = "select * from Students where DeletedAt IS null";
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!listviewStu.Items.ContainsKey(reader["StudentID"].ToString()))
                    {
                        var itemStudent = listviewStu.Items.Add(reader["StudentID"].ToString());
                        itemStudent.SubItems.Add(reader["FullName"].ToString());
                        itemStudent.SubItems.Add(reader["Birthday"].ToString());
                        itemStudent.SubItems.Add(reader["Gender"].ToString());
                        itemStudent.SubItems.Add(reader["Phone"].ToString());
                        itemStudent.SubItems.Add(reader["Address"].ToString());
                        itemStudent.SubItems.Add(reader["Email"].ToString());
                        itemStudent.SubItems.Add(reader["Avatar"].ToString());
                        itemStudent.SubItems.Add(reader["CourseID"].ToString());
                        itemStudent.SubItems.Add(reader["CreatedAt"].ToString());
                        itemStudent.SubItems.Add(reader["UpdatedAt"].ToString());

                    }
                }
                conn.Close();
            }
        }
        public int InsertStudent(string FullName, string Birthday, string Gender, string Phone, string Address, string Email, string Avatar,string CourseID, OpenFileDialog openFileDialog)
        {
            string sqlInsert = "INSERT INTO Students(FullName,Birthday,Gender,Phone,Address,Email,Avatar,CourseID,CreatedAt) VALUES(@FullName,@Birthday,@Gender,@Phone,@Address,@Email,@Avatar,@CourseID,@CreatedAt) SELECT SCOPE_IDENTITY()";
            // select scope_identity(): lay ra duoc Id vua dc insert
            int lastInsertId = 0;
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                // kiem tra du lieu dau vao 
                cmd.Parameters.AddWithValue("@FullName", FullName ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Birthday", Birthday ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Gender", Gender ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Phone", Phone ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Address", Address ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Email", Email ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Avatar", Avatar ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@CourseID", CourseID.ToString() ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                // upload image vao thu muc tren source code cua minh
                if (!string.IsNullOrEmpty(Avatar))
                {
                    string pathApp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 25));
                    // duong dan cua poject
                    try
                    {
                        //copy file
                        System.IO.File.Copy(openFileDialog.FileName, pathApp + Avatar);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

                }
                lastInsertId = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
            }
            return lastInsertId;
        }
        public bool UpdateStudent(int StudentID, string FullName, string Birthday, string Gender, string Phone, string Address, string Email, string Avatar,string CourseID, bool hasFile, OpenFileDialog openFileDialog)
        {
            string sqlUpdate = "UPDATE Students SET FullName=@FullName, Birthday=@Birthday,Gender=@Gender,Phone=@Phone,Address=@Address,Email=@Email,Avatar=@Avatar,CourseID=@CourseID, UpdatedAt=@UpdatedAt WHERE StudentID=@StudentID";
            bool checkUpdate = false;
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                cmd.Parameters.AddWithValue("@StudentID", StudentID);
                cmd.Parameters.AddWithValue("@FullName", FullName ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Birthday", Birthday ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Gender", Gender ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Phone", Phone ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Address", Address ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Email", Email ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@Avatar", Avatar ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@CourseID", CourseID.ToString() ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                conn.Close();
                checkUpdate = true;
                if (hasFile)
                {
                    //tien hanh copy anh - nguoi co thay doi anh moi
                    // upload image vao thu muc tren source code cua minh
                    if (!string.IsNullOrEmpty(Avatar))
                    {
                        string pathApp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 25));
                        // duong dan cua poject
                        try
                        {
                            //copy file
                            System.IO.File.Copy(openFileDialog.FileName, pathApp + Avatar);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }

                    }
                }
            }
            return checkUpdate;
        }
        public bool DeleteStudentID(int StudentID)
        {
            string sqlDelete = "UPDATE Students SET DeletedAt = @DeletedAt WHERE StudentID=@StudentID ";
            bool checkDeleted = false;
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.Parameters.AddWithValue("@StudentID", StudentID);
                cmd.Parameters.AddWithValue("@DeletedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                conn.Close();
                checkDeleted = true;
            }
            return checkDeleted;

        }
    }

    }


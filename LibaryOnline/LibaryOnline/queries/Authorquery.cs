using System.Data.SqlClient;

namespace LibaryOnline.queries
{
    public class Authorquery
    {

        public void GetAllDataAuthor(ListView listAuthor)
        {
            string sql = "Select * from author where deleted_at is null";
            using (SqlConnection conn =Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql , conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (!listAuthor.Items.ContainsKey(reader["id"].ToString()))
                    {
                        var itemAuthor = listAuthor.Items.Add(reader["id"].ToString());
                        itemAuthor.SubItems.Add(reader["fullname"].ToString());
                        itemAuthor.SubItems.Add(reader["nickname"].ToString());
                        itemAuthor.SubItems.Add(reader["avatar"].ToString());
                        itemAuthor.SubItems.Add(reader["gender"].ToString());
                        itemAuthor.SubItems.Add(reader["birthday"].ToString());
                        itemAuthor.SubItems.Add(reader["address"].ToString());
                        itemAuthor.SubItems.Add(reader["biography"].ToString());
                        itemAuthor.SubItems.Add(reader["status"].ToString());
                        itemAuthor.SubItems.Add(reader["created_at"].ToString());
                        itemAuthor.SubItems.Add(reader["updated_at"].ToString());

                    }
                }
                conn.Close();
            }
        }
        public static bool DeleteAuthorById(int id)
        {
            string sqlStr = "update author set deleted_at = @deleted_at where id =@id";
            bool chekDel = false;
                using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd  = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@deleted_at",DateTime.Now.ToString("yyyy-MM-dd"));
            }
        }

        public bool UpdateAuthor(int id,string fullname, string nicknme, string gender, string birthday, string address, string biography, string status, string avatar,bool hasFile, OpenFileDialog openFileDialog)
        {
            string sqlUpdate = "UPDATE author SET fullname=@fullname, nickname=@nickname,gender=@gender,birthday=@birthday,address=@address,biography=@biography,status=@status,avatar=@avatar, updated_at=@update_at WHERE id=@id";
            bool checkUpdate = false;
            using (SqlConnection conn =Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlUpdate,conn);
                cmd.Parameters.AddWithValue("@id", id );
                cmd.Parameters.AddWithValue("@fullname", fullname ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@nickname", nicknme ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@gender", gender ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@birthday", birthday ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@address", address ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@biography", biography ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@status", status ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@avatar", avatar ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@update_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                conn.Close();
                checkUpdate = true; 
                if(hasFile)
                {
                    //tien hanh copy anh - nguoi co thay doi anh moi
                    // upload image vao thu muc tren source code cua minh
                    if (!string.IsNullOrEmpty(avatar))
                    {
                        string pathApp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 25));
                        // duong dan cua poject
                        try
                        {
                            //copy file
                            System.IO.File.Copy(openFileDialog.FileName, pathApp + avatar);

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
        public int InsertAuthor(string fullname, string nicknme, string gender, string birthday, string address, string biography, string status, string avatar, OpenFileDialog openFileDialog)
        {
            string sqlInsert = "INSERT INTO author(fullname,nickname,gender,birthday,address,biography,status,avatar,created_at) VALUES(@fullname,@nickname,@gender,@birthday,@address,@biography,@status,@avatar,@created_at) SELECT SCOPE_IDENTITY()";
            // select scope_identity(): lay ra duoc Id vua dc insert
            int lastInsertId = 0;
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlInsert, conn);
                // kiem tra du lieu dau vao 
                cmd.Parameters.AddWithValue("@fullname", fullname ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@nickname", nicknme ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@gender", gender ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@birthday", birthday ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@address", address ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@biography", biography ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@status", status ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@avatar", avatar ?? DBNull.Value.ToString());
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                // upload image vao thu muc tren source code cua minh
                if (!string.IsNullOrEmpty(avatar))
                {
                    string pathApp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 25));
                    // duong dan cua poject
                    try
                    {
                        //copy file
                        System.IO.File.Copy(openFileDialog.FileName, pathApp + avatar);

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
    }
}

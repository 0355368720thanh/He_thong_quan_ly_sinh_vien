using LibaryOnline.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryOnline.queries
{
    public class loginuser
    {
        public loginmodels checkLogin(string email, string password)
        {
            loginmodels matchingData = new loginmodels();
            using (SqlConnection conn = Database.GetConnection())
            {
                string querySql = "select * from students where email =@email and password =@password";
                SqlCommand cmd = new SqlCommand(querySql, conn);
                //truyen tham so
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                conn.Open();//mo ket noi
                //thuc thi cau lenh
                using (SqlDataReader reader=cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //do du lieu tu table database sang models login
                        matchingData.id = reader["id"].ToString();
                        matchingData.code = reader["code"].ToString();
                        matchingData.email = reader["email"].ToString();
                        matchingData.phone = reader["phone"].ToString();
                        matchingData.address = reader["address"].ToString();
                        matchingData.fullname = reader["fullname"].ToString();
                    }
                    conn.Close();//dong ket noi (giai phong tai nguyen)
                }
            }
                return matchingData;
        }
    }
}

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CMS
{
    public partial class LoginForm : Form
    {
        SqlConnection conn;
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            conn = Database.GetConnection();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(" select * from Users inner join Roles on" +
                " Users.RoleID = Roles.RoleID where Username = @Username and Password = @Password", conn);
            cmd.Parameters.AddWithValue("@Username",txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                string RoleName = dt.Rows[0][5].ToString();
                if (RoleName == "Admin")
                {
                    Database.RoleName = "A";
                    MessageBox.Show("Welcome Admin");
                }
                else if (RoleName == "Instructor")
                {
                    Database.RoleName = "B";
                    MessageBox.Show("Welcome Instructor");
                }
                else
                {
                    Database.RoleName = "S";
                    MessageBox.Show("Welcome Student");
                }
                Dashboard home = new Dashboard();
                home.Show();
                this.Hide();
            }


            else 
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
            conn.Close();
        }
       

        private void btnExit_Click(object sender, EventArgs e)
        {

            string message = " Are you sure?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}


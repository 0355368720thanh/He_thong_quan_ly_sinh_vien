using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibaryOnline.queries;
using LibaryOnline.models;
using LibaryOnline.Logging;

namespace LibaryOnline
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            conn = Database.GetConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            try
            {
                loginuser loginuser = new loginuser();
                loginmodels datauser = loginuser.checkLogin(username, password);
                if (string.IsNullOrEmpty(datauser.id) || string.IsNullOrEmpty(datauser.email))
                {
                    MessageBox.Show("Account invalid");
                }
                else
                {
                    MessageBox.Show("Login success");
                    //luu cac thong tin cua nguoi dung
                    logininfo.userid = datauser.id;
                    logininfo.emailuser = datauser.email;
                    logininfo.nameuser = datauser.fullname;
                    FormDashboard home = new FormDashboard();
                    home.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
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

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }
    }
}

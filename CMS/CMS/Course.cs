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
using System.IO;

namespace CMS
{
    public partial class Course : Form
    {
        private string selectedFilePath;
        SqlConnection conn;
        public Course()
        {
            InitializeComponent();
            conn = Database.GetConnection();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            txtFilePath.Text = dlg.FileName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile(txtFilePath.Text);
            MessageBox.Show("Save successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void SaveFile(string filePath)
        {
            try
            {
                using (Stream stream = File.OpenRead(filePath))
                {
                    byte[] buffer = new byte[stream.Length];
                    stream.Read(buffer, 0, buffer.Length);
                    string Asname = cboAss.SelectedValue.ToString();
                    string query = "insert into Submission(Submission,AssignmentID)values (@Submission,@AssignmentID)";
                    using (SqlConnection conn = GetConnection())
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.Add("@Submission", SqlDbType.VarBinary).Value = buffer;
                        cmd.Parameters.Add("@AssignmentID", SqlDbType.VarChar).Value = Asname;
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
          

        }
        private SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=LAPTOP-NN8LKB4S\SQLEXPRESS;Initial Catalog=CMS SYSTEMS;Integrated Security=True");
        }

        private void Course_Load(object sender, EventArgs e)
        {
            GetName();
        }
        private void loadData()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string message = " Are you sure?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
        }
        public void GetName()
        {
            conn.Open();
            string query = "select * from Assignments";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cboAss.DataSource = table;
            cboAss.DisplayMember = "AssignmentName";
            cboAss.ValueMember = "AssignmentID";

            conn.Close();
        }
    }
}

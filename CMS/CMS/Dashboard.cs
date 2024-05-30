using CMS.Queries;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Button = System.Windows.Forms.Button;
using Microsoft.VisualBasic.Logging;


namespace CMS
{
    public partial class Dashboard : Form
    {
        SqlConnection conn;
        private object panelContainer;
        public string Username;
        public Dashboard()
        {
            InitializeComponent();
            conn = Database.GetConnection();
            if (Database.RoleName == "A")
            {
                tabControlDashboard.Enabled = true;
            }
            else if (Database.RoleName == "B")
            {
                tabPageInstructor.Enabled = false;
                btnDeStu.Enabled = false;
            }
            else
            {
                tabPageInstructor.Enabled = false;
                tabPageStudent.Enabled = false;
                btnRemovecourse.Enabled = false;
                btnCours.Enabled = false;
                txtCour.Enabled = false;
            }
        }
       

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            string Male = radMaleStu.Text.Trim();
            string Birthday = BirthStu.Value.ToString("yyyy-MM-dd");
            string Female = radFemStu.Text.Trim();
            string FullName = txtNameStu.Text.Trim();
            string Phone = txtPhoneStu.Text.Trim();
            string Email = txtEmailStu.Text.Trim();
            string Address = txtAddStu.Text.Trim();
            string CourseID = cboCourses.SelectedValue.ToString();
            string Gender = radFemStu.Checked ? "Female" : "Male";





            //su ly upload anh 
            TimeSpan timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            long secondTime = Convert.ToInt64(timeSpan.TotalSeconds);
            string FileName = secondTime + "-" + System.IO.Path.GetFileName(openFileDialogAvatar.FileName);
            // dam bao khong trung ten anh de upload len thu muc upload trong project
            string pathUploadFile = "\\Upload\\";
            string fullPathUploadFile = pathUploadFile + FileName;
            //validate data
            if (string.IsNullOrEmpty(FullName))
            {
                MessageBox.Show("Enter FullName , please");
                return;
            }
            if (string.IsNullOrEmpty(Male) && string.IsNullOrEmpty(Female))
            {

                MessageBox.Show("Enter Gender , please");
                return;
            }
            if (string.IsNullOrEmpty(Birthday))
            {
                MessageBox.Show("Enter Birthday , please");
                return;
            }


            StudentQuery studentQuery = new StudentQuery();
            int idStudents = studentQuery.InsertStudent(FullName, Birthday, Gender, Phone, Address, Email, fullPathUploadFile, CourseID, openFileDialogAvatar);
            if (idStudents > 0)
            {
                MessageBox.Show("Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //do du lieu ra listview
                ListViewItem newItems = new ListViewItem(idStudents.ToString());
                newItems.SubItems.Add(FullName);
                newItems.SubItems.Add(Birthday);
                newItems.SubItems.Add(Gender);
                newItems.SubItems.Add(Phone);
                newItems.SubItems.Add(Address);
                newItems.SubItems.Add(Email);
                newItems.SubItems.Add(fullPathUploadFile);
                newItems.SubItems.Add(CourseID);
                newItems.SubItems.Add(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                listViewStu.Items.Add(newItems);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            cboSeach.Text = "Student ID";
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "select * from Temple";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader read = command.ExecuteReader();
                DataTable data = new DataTable();
                data.Load(read);
                dgvGrade.DataSource = data;
                dgvGrade.Visible = false;
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            GetCourses();
            Course();
            listViewStu.View = View.Details;
            listViewStu.GridLines = true;
            listViewStu.FullRowSelect = true;
            listViewStu.Columns.Add("StudentID", 50);
            listViewStu.Columns.Add("FullName", 150);
            listViewStu.Columns.Add("Birthday", 120);
            listViewStu.Columns.Add("Gender", 50);
            listViewStu.Columns.Add("Phone", 100);
            listViewStu.Columns.Add("Address", 100);
            listViewStu.Columns.Add("Email", 150);
            listViewStu.Columns.Add("Avatar", 120);
            listViewStu.Columns.Add("Course", 100);
            listViewStu.Columns.Add("CreatedAt", 150);
            listViewStu.Columns.Add("UpdatedAt", 150);


            listViewIns.View = View.Details;
            listViewIns.GridLines = true;
            listViewIns.FullRowSelect = true;
            listViewIns.Columns.Add("InstructorID", 50);
            listViewIns.Columns.Add("FullName", 150);
            listViewIns.Columns.Add("Gender", 50);
            listViewIns.Columns.Add("Email", 150);
            listViewIns.Columns.Add("Birthday", 120);
            listViewIns.Columns.Add("Phone", 100);
            listViewIns.Columns.Add("Address", 100);
            listViewIns.Columns.Add("Specialized", 150);
            listViewIns.Columns.Add("CreatedAt", 150);
            listViewIns.Columns.Add("UpdatedAt", 150);

        }

        private void btnUpStu_Click(object sender, EventArgs e)
        {
           // Course();
            string Male = radMaleStu.Text.Trim();
            string Birthday = BirthStu.Value.ToString("yyyy-MM-dd");
            string Female = radFemStu.Text.Trim();
            string FullName = txtNameStu.Text.Trim();
            string Phone = txtPhoneStu.Text.Trim();
            string Email = txtEmailStu.Text.Trim();
            string Address = txtAddStu.Text.Trim();
            string Gender = radFemStu.Checked ? "Female" : "Male";
            string CourseID = cboCourses.SelectedValue.ToString();
            string fullPathUploadFile;
            //string CourseID = cboCourse.Text.Trim();
            bool hasUploadFile;

            if (File.Exists(openFileDialogAvatar.FileName))
            {
                //su ly upload anh 
                TimeSpan timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1));
                long secondTime = Convert.ToInt64(timeSpan.TotalSeconds);
                string FileName = secondTime + "-" + System.IO.Path.GetFileName(openFileDialogAvatar.FileName);
                // dam bao khong trung ten anh de upload len thu muc upload trong project
                string pathUploadFile = "\\Upload\\";
                fullPathUploadFile = pathUploadFile + FileName;
                hasUploadFile = true;

            }
            else
            {
                fullPathUploadFile = txtFile.Text.Trim();
                hasUploadFile = false;

            }
            //validate data
            if (string.IsNullOrEmpty(FullName))
            {
                MessageBox.Show("Enter Name , please");
                return;
            }
            if (string.IsNullOrEmpty(Male) && string.IsNullOrEmpty(Female))
            {

                MessageBox.Show("Enter Gender , please");
                return;
            }
            if (string.IsNullOrEmpty(Birthday))
            {
                MessageBox.Show("Enter Birthday , please");
                return;
            }
            int idStudent = Convert.ToInt32(txtStudent.Text.Trim());
            StudentQuery studentquery = new StudentQuery();
            bool update = studentquery.UpdateStudent(idStudent, FullName, Birthday, Gender, Phone, Address, Email, fullPathUploadFile, CourseID, hasUploadFile, openFileDialogAvatar);
            if (update)
            {
                var dataItem = listViewStu.SelectedItems[0];
                dataItem.SubItems[1].Text = FullName;
                dataItem.SubItems[2].Text = Birthday;
                dataItem.SubItems[3].Text = Gender;
                dataItem.SubItems[4].Text = Phone;
                dataItem.SubItems[5].Text = Address;
                dataItem.SubItems[6].Text = Email;
                dataItem.SubItems[7].Text = fullPathUploadFile;
                dataItem.SubItems[8].Text = CourseID;




                MessageBox.Show("Update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Update Failure", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeStu_Click(object sender, EventArgs e)
        {
            if (listViewStu.SelectedItems.Count > 0)
            {
                int StudentID = Convert.ToInt32(txtStudent.Text.Trim());
                try
                {
                    StudentQuery studentQuery = new StudentQuery();
                    bool del = studentQuery.DeleteStudentID(StudentID);
                    if (del)
                    {
                        for (int i = listViewStu.Items.Count - 1; i >= 0; i--)
                        {
                            if (listViewStu.Items[i].Selected)
                            {
                                listViewStu.Items[i].Remove();
                            }
                        }
                        MessageBox.Show("Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failure", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("choose data to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void listViewStu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStu.SelectedItems.Count > 0)
            {
                //lay du lieu tung cot trong listview do vao cac textbox ben trong form
                txtStudent.Text = listViewStu.SelectedItems[0].SubItems[0].Text.Trim();
                txtNameStu.Text = listViewStu.SelectedItems[0].SubItems[1].Text.Trim();
                string birthday = listViewStu.SelectedItems[0].SubItems[2].Text.Trim();
                BirthStu.Value = Convert.ToDateTime(birthday);
                string gender = listViewStu.SelectedItems[0].SubItems[3].Text.Trim();
                if (gender == "Male")
                {
                    radMaleStu.Checked = true;
                    radFemStu.Checked = false;
                }
                else if (gender == "Female")
                {
                    radMaleStu.Checked = false;
                    radFemStu.Checked = true;
                }
                txtPhoneStu.Text = listViewStu.SelectedItems[0].SubItems[4].Text.Trim();
                txtEmailStu.Text = listViewStu.SelectedItems[0].SubItems[5].Text.Trim();
                txtAddStu.Text = listViewStu.SelectedItems[0].SubItems[6].Text.Trim();
                string pathImg = listViewStu.SelectedItems[0].SubItems[7].Text.Trim();
                string pathApp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 26));
                if (File.Exists(@pathApp + pathImg))
                {
                    pictureBoxStu.Image = Image.FromFile(@pathApp + pathImg);
                    pictureBoxStu.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtFile.Text = pathImg;
                }
                cboCourses.SelectedValue = listViewStu.SelectedItems[0].SubItems[8].Text.Trim();

            }
        }

        private void btnAddIns_Click(object sender, EventArgs e)
        {
            string MaleIn = radMaleIn.Text.Trim();
            string BirthdayIns = BirthIns.Value.ToString("yyyy-MM-dd");
            string FemaleIn = radFemIn.Text.Trim();
            string FullNameIn = txtNameIns.Text.Trim();
            string PhoneIn = txtphoneIns.Text.Trim();
            string EmailIn = txtEmailIns.Text.Trim();
            string AddressIn = txtAddressIns.Text.Trim();
            string Specialized = cboIns.Text.Trim();
            string GenderIn = radFemIn.Checked ? "Female" : "Male";
            if (string.IsNullOrEmpty(FullNameIn))
            {
                MessageBox.Show("Enter FullName , please");
                return;
            }
            if (string.IsNullOrEmpty(MaleIn) && string.IsNullOrEmpty(FemaleIn))
            {

                MessageBox.Show("Enter Gender , please");
                return;
            }
            if (string.IsNullOrEmpty(BirthdayIns))
            {
                MessageBox.Show("Enter Birthday , please");
                return;
            }
            InstructorQuery instructorQuery = new InstructorQuery();
            int idInstructor = instructorQuery.InsertInstructor(FullNameIn, GenderIn, EmailIn, BirthdayIns, PhoneIn, AddressIn, Specialized);
            if (idInstructor > 0)
            {
                MessageBox.Show("Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //do du lieu ra listview
                ListViewItem newItems = new ListViewItem(idInstructor.ToString());
                newItems.SubItems.Add(FullNameIn);
                newItems.SubItems.Add(BirthdayIns);
                newItems.SubItems.Add(GenderIn);
                newItems.SubItems.Add(PhoneIn);
                newItems.SubItems.Add(AddressIn);
                newItems.SubItems.Add(EmailIn);
                newItems.SubItems.Add(Specialized);
                newItems.SubItems.Add(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                listViewIns.Items.Add(newItems);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnUpIns_Click(object sender, EventArgs e)
        {
            string MaleIn = radMaleIn.Text.Trim();
            string BirthdayIns = BirthIns.Value.ToString("yyyy-MM-dd");
            string FemaleIn = radFemIn.Text.Trim();
            string FullNameIn = txtNameIns.Text.Trim();
            string PhoneIn = txtphoneIns.Text.Trim();
            string EmailIn = txtEmailIns.Text.Trim();
            string AddressIn = txtAddressIns.Text.Trim();
            string Specialized = cboIns.Text.Trim();
            string GenderIn = radFemIn.Checked ? "Female" : "Male";
            if (string.IsNullOrEmpty(FullNameIn))
            {
                MessageBox.Show("Enter FullName , please");
                return;
            }
            if (string.IsNullOrEmpty(MaleIn) && string.IsNullOrEmpty(FemaleIn))
            {

                MessageBox.Show("Enter Gender , please");
                return;
            }
            if (string.IsNullOrEmpty(BirthdayIns))
            {
                MessageBox.Show("Enter Birthday , please");
                return;
            }
            int idInstructor = Convert.ToInt32(txtIns.Text.Trim());
            InstructorQuery instructorQuery = new InstructorQuery();
            bool update = instructorQuery.UpdateInstructor(idInstructor, FullNameIn, GenderIn, EmailIn, BirthdayIns, PhoneIn, AddressIn, Specialized);
            if (update)
            {
                var dataItem = listViewIns.SelectedItems[0];
                dataItem.SubItems[1].Text = FullNameIn;
                dataItem.SubItems[2].Text = GenderIn;
                dataItem.SubItems[3].Text = EmailIn;
                dataItem.SubItems[4].Text = BirthdayIns;
                dataItem.SubItems[5].Text = PhoneIn;
                dataItem.SubItems[6].Text = AddressIn;
                dataItem.SubItems[7].Text = Specialized;


                MessageBox.Show("Update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Update Failure", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeIns_Click(object sender, EventArgs e)
        {
            if (listViewIns.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(txtIns.Text.Trim());
                try
                {
                    InstructorQuery instructorQuery = new InstructorQuery();
                    bool del = instructorQuery.DeleteInstructorID(id);
                    if (del)
                    {
                        for (int i = listViewIns.Items.Count - 1; i >= 0; i--)
                        {
                            if (listViewIns.Items[i].Selected)
                            {
                                listViewIns.Items[i].Remove();
                            }
                        }
                        MessageBox.Show("Succesfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failure", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("choose data to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void listViewIns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewIns.SelectedItems.Count > 0)
            {
                //lay du lieu tung cot trong listview do vao cac textbox ben trong form
                txtIns.Text = listViewIns.SelectedItems[0].SubItems[0].Text.Trim();
                txtNameIns.Text = listViewIns.SelectedItems[0].SubItems[1].Text.Trim();
                string gender = listViewIns.SelectedItems[0].SubItems[2].Text.Trim();
                if (gender == "Male")
                {
                    radMaleIn.Checked = true;
                    radFemIn.Checked = false;
                }
                else if (gender == "Female")
                {
                    radMaleIn.Checked = false;
                    radFemIn.Checked = true;
                }
                txtEmailIns.Text = listViewIns.SelectedItems[0].SubItems[3].Text.Trim();
                string birthday = listViewIns.SelectedItems[0].SubItems[4].Text.Trim();
                BirthIns.Value = Convert.ToDateTime(birthday);
                txtphoneIns.Text = listViewIns.SelectedItems[0].SubItems[5].Text.Trim();
                txtAddressIns.Text = listViewIns.SelectedItems[0].SubItems[6].Text.Trim();
                cboIns.Text = listViewIns.SelectedItems[0].SubItems[7].Text.Trim();


            }
        }

        private void tabControlDashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlDashboard.SelectedTab == tabControlDashboard.TabPages["tabPageStudent"])
            {
                listViewStu.Items.Clear();
                listViewStu.Update();
                listViewStu.Refresh();
                StudentQuery studentQuery = new StudentQuery();
                studentQuery.GetAllDataStudent(listViewStu);
            }
            if (tabControlDashboard.SelectedTab == tabControlDashboard.TabPages["tabPageInstructor"])
            {
                listViewIns.Items.Clear();
                listViewIns.Update();
                listViewIns.Refresh();
                InstructorQuery instructorQuery = new InstructorQuery();
                instructorQuery.GetAllDataInstructor(listViewIns);
            }
        }

        private void btnCours_Click(object sender, EventArgs e)
        {
            string courseName = txtCour.Text;
            int courseId = AddCourseToDatabase(courseName);
            MessageBox.Show("Course added successfully!");
            AddCourseButton(courseId, courseName);

        }
        private int AddCourseToDatabase(string courseName)
        {
            string connectionString = @"Data Source=LAPTOP-NN8LKB4S\SQLEXPRESS;Initial Catalog=CMS SYSTEMS;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Courses (CourseName) OUTPUT INSERTED.CourseID VALUES (@CourseName)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseName", courseName);
                    return (int)command.ExecuteScalar();
                }
            }
        }
        private void AddCourseButton(int courseId, string courseName)
        {
            Button courseButton = new Button
            {
                Text = courseName,
                Tag = courseId,
                Width = 200,
                Height = 150,
                Margin = new Padding(5),
                ForeColor = System.Drawing.Color.White
            };

            courseButton.Click += CourseButton_Click;

            flowLayoutPanelCourses.Controls.Add(courseButton);
        }
        private void CourseButton_Click(object sender, EventArgs e)
        {
            int courseId = (int)((Button)sender).Tag;

            OpenNewForm(courseId);
        }
        private void OpenNewForm(int courseId)
        {

            Course course = new Course();
            course.Show();
            this.Hide();
        }

        public void GetCourses()
        {

            string selectQuery = "SELECT CourseID, CourseName FROM Courses;";
            using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NN8LKB4S\SQLEXPRESS;Initial Catalog=CMS SYSTEMS;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int existingCourseID = (int)reader["CourseID"];
                        string existingCourseName = (string)reader["CourseName"];


                        // Create button for each existing course and add to FlowLayoutPanel
                        Button existingButton = new Button();
                        existingButton.Text = existingCourseName;
                        existingButton.Tag = existingCourseID; // Lưu CourseID trong Tag để sử dụng khi button được nhấn
                        existingButton.Click += CourseButton_Click; // Gắn sự kiện khi button được nhấn
                        existingButton.Width = 200;  // Đặt độ rộng mong muốn
                        existingButton.Height = 150;
                        existingButton.ForeColor = System.Drawing.Color.White;
                        flowLayoutPanelCourses.Controls.Add(existingButton);
                    }
                }
            }
        }


        private void btnButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnRemovecourse_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanelCourses.Controls.Count > 0)
            {
                Button lastButton = (Button)flowLayoutPanelCourses.Controls[flowLayoutPanelCourses.Controls.Count - 1];
                flowLayoutPanelCourses.Controls.Remove(lastButton);
                int courseIDToRemove = (int)lastButton.Tag;

            }
            else
            {
                MessageBox.Show("There are no courses to remove.", "Warning");
            }
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialogAvatar.InitialDirectory = "C://Desktop";
            openFileDialogAvatar.Title = "Select image to be upload";
            openFileDialogAvatar.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            openFileDialogAvatar.FilterIndex = 1;
            if (openFileDialogAvatar.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialogAvatar.CheckFileExists)
                {
                    //gan anh upload va hien thi vao pictureBox
                    pictureBoxStu.Image = new Bitmap(openFileDialogAvatar.FileName);
                    pictureBoxStu.SizeMode = PictureBoxSizeMode.StretchImage;
                    //lay duong dan cua anh 
                    string pathImage = System.IO.Path.GetFullPath(openFileDialogAvatar.FileName);
                    txtFile.Text = pathImage;
                }
                else
                {
                    MessageBox.Show("Can not found File");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = " Are you sure?";
            string title = "Close window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }

        }

        private void txtStuID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public DataTable HienDL(string sql)
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reaer = cmd.ExecuteReader();
            dt.Load(reaer);
            conn.Close();
            return dt;
        }
        private void btnSea_Click(object sender, EventArgs e)
        {
            dgvGrade.Visible = true;
            try
            {
                if (txtStuID.Text == "")
                {
                    MessageBox.Show("Please enter correct value!!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (cboSeach.Text == "Student ID")
                    {
                        dgvGrade.DataSource = HienDL("select * from Temple where StudentID like '%" + txtStuID.Text + "%'");

                    }
                    if (cboSeach.Text == "Name")
                    {
                        dgvGrade.DataSource = HienDL("select * from Temple where FullName like '%" + txtStuID.Text + "%'");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Dashboard_Load(sender, e);
        }

        private void txtPhoneStu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtphoneIns_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
        private void Course()
        {
            conn.Open();
            string query = "select * from Courses";
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
            dataAdapter.Fill(table);
            cboCourses.DataSource = table;
            cboCourses.DisplayMember = "CourseName";
            cboCourses.ValueMember = "CourseID";

            conn.Close();
        }
    }
}

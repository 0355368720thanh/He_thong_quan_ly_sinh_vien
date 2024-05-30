using LibaryOnline.queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibaryOnline
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            listViewAuthor.View = View.Details;
            listViewAuthor.GridLines = true;
            listViewAuthor.FullRowSelect = true;
            listViewAuthor.Columns.Add("ID", 50);
            listViewAuthor.Columns.Add("Name", 150);
            listViewAuthor.Columns.Add("NickName", 120);
            listViewAuthor.Columns.Add("Avatar", 120);
            listViewAuthor.Columns.Add("Gender", 50);
            listViewAuthor.Columns.Add("Birthday", 100);
            listViewAuthor.Columns.Add("Address", 100);
            listViewAuthor.Columns.Add("Biography", 200);
            listViewAuthor.Columns.Add("Status", 50);
            listViewAuthor.Columns.Add("Created At", 150);
            listViewAuthor.Columns.Add("Updated At", 150);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogAvatar.InitialDirectory = "C://Desktop";
            openFileDialogAvatar.Title = "Select image to be upload";
            openFileDialogAvatar.Filter = "Image Files (*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            openFileDialogAvatar.FilterIndex = 1;
            if (openFileDialogAvatar.ShowDialog() == DialogResult.OK)
            {
                // thuc su co upload
                if (openFileDialogAvatar.CheckFileExists)
                {
                    //gan anh upload va hien thi vao pictureBox
                    pictureBoxAvatar.Image = new Bitmap(openFileDialogAvatar.FileName);
                    pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    //lay duong dan cua anh 
                    string pathImage = System.IO.Path.GetFullPath(openFileDialogAvatar.FileName);
                    txtFileName.Text = pathImage;
                }
                else
                {
                    MessageBox.Show("Can not found File");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Male = radMal.Text.Trim();
            string birthday = dateBirthday.Value.ToString("yyyy-MM-dd");
            string Female = radFemale.Text.Trim();
            string FullName = txtFullname.Text.Trim();
            string NickName = txtnickname.Text.Trim();
            string Status = cboStatus.Text.Trim();
            string Biography = txtbiography.Text.Trim();
            string Address = txtAddress.Text.Trim();
            string gender = radFemale.Checked ? "Female" : "Male";


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
                MessageBox.Show("Enter Name , please");
                return;
            }
            if (string.IsNullOrEmpty(Male) && string.IsNullOrEmpty(Female))
            {

                MessageBox.Show("Enter Gender , please");
                return;
            }
            if (string.IsNullOrEmpty(birthday))
            {
                MessageBox.Show("Enter Birthday , please");
                return;
            }
            if (string.IsNullOrEmpty(Status))
            {
                MessageBox.Show("Enter Status , please");
                return;
            }

            Authorquery authorquery = new Authorquery();
            int idAuthor = authorquery.InsertAuthor(FullName, NickName, gender, birthday, Address, Biography, Status, fullPathUploadFile, openFileDialogAvatar);
            if (idAuthor > 0)
            {
                MessageBox.Show("Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //do du lieu ra listview
                ListViewItem newItems = new ListViewItem(idAuthor.ToString());
                newItems.SubItems.Add(FullName);
                newItems.SubItems.Add(NickName);
                newItems.SubItems.Add(fullPathUploadFile);
                newItems.SubItems.Add(gender);
                newItems.SubItems.Add(birthday);
                newItems.SubItems.Add(Address);
                newItems.SubItems.Add(Biography);
                newItems.SubItems.Add(Status);
                newItems.SubItems.Add(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"));
                listViewAuthor.Items.Add(newItems);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void tabControlDashboard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlDashboard.SelectedTab == tabControlDashboard.TabPages["tabPageAuthor"])
            {
                listViewAuthor.Items.Clear();
                listViewAuthor.Update();
                listViewAuthor.Refresh();
                Authorquery authorquery = new Authorquery();
                authorquery.GetAllDataAuthor(listViewAuthor);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listViewAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAuthor.SelectedItems.Count > 0)
            {
                //lay du lieu tung cot trong listview do vao cac textbox ben trong form
                txtID.Text = listViewAuthor.SelectedItems[0].SubItems[0].Text.Trim();
                txtFullname.Text = listViewAuthor.SelectedItems[0].SubItems[1].Text.Trim();
                txtnickname.Text = listViewAuthor.SelectedItems[0].SubItems[2].Text.Trim();
                string pathImg = listViewAuthor.SelectedItems[0].SubItems[3].Text.Trim();
                string pathApp = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 26));
                if (File.Exists(@pathApp + pathImg))
                {
                    pictureBoxAvatar.Image = Image.FromFile(@pathApp + pathImg);
                    pictureBoxAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                    txtFileName.Text = pathImg;
                }
                string gender = listViewAuthor.SelectedItems[0].SubItems[4].Text.Trim();
                if (gender == "Male")
                {
                    radMal.Checked = true;
                    radFemale.Checked = false;
                }
                else if (gender == "Female")
                {
                    radMal.Checked = false;
                    radFemale.Checked = true;
                }
                string birthday = listViewAuthor.SelectedItems[0].SubItems[5].Text.Trim();
                dateBirthday.Value = Convert.ToDateTime(birthday);
                txtAddress.Text = listViewAuthor.SelectedItems[0].SubItems[6].Text.Trim();
                txtbiography.Text = listViewAuthor.SelectedItems[0].SubItems[7].Text.Trim();
                cboStatus.SelectedItem = listViewAuthor.SelectedItems[0].SubItems[8].Text.Trim();


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Male = radMal.Text.Trim();
            string birthday = dateBirthday.Value.ToString("yyyy-MM-dd");

            string Female = radFemale.Text.Trim();
            string FullName = txtFullname.Text.Trim();
            string NickName = txtnickname.Text.Trim();
            string Status = cboStatus.Text.Trim();
            string Biography = txtbiography.Text.Trim();
            string Address = txtAddress.Text.Trim();
            string gender = radFemale.Checked ? "Female" : "Male";

            string fullPathUploadFile;
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
                fullPathUploadFile = txtFileName.Text.Trim();
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
            if (string.IsNullOrEmpty(birthday))
            {
                MessageBox.Show("Enter Birthday , please");
                return;
            }
            if (string.IsNullOrEmpty(Status))
            {
                MessageBox.Show("Enter Status , please");
                return;
            }

            int idAuthor = Convert.ToInt32(txtID.Text.Trim());
            Authorquery authorquery = new Authorquery();
            bool update = authorquery.UpdateAuthor(idAuthor, FullName, NickName, gender, birthday, Address, Biography, Status, fullPathUploadFile, hasUploadFile, openFileDialogAvatar);
            if (update)
            {
                //listViewAuthor.BeginUpdate();
                //listViewAuthor.Refresh();
                //listViewAuthor.Update();
                //listViewAuthor.EndUpdate();
                var dataItem = listViewAuthor.SelectedItems[0];
                dataItem.SubItems[1].Text = FullName;
                dataItem.SubItems[2].Text = NickName;
                dataItem.SubItems[3].Text = gender;
                dataItem.SubItems[4].Text = birthday;
                dataItem.SubItems[5].Text = Address;
                dataItem.SubItems[6].Text = Biography;
                dataItem.SubItems[7].Text = Status;
                dataItem.SubItems[8].Text = fullPathUploadFile;



                MessageBox.Show("Update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Update Failure", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewAuthor.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                try
                {
                    listViewAuthor.Update();
                    listViewAuthor.Refresh();
                    Authorquery authorquery = new Authorquery();
                    bool del = authorquery.DeleteAuthorById(id);
                    if (del)
                    {
                        for (int i = listViewAuthor.Items.Count - 1; i >= 0; i--)
                        {
                            if (listViewAuthor.Items[i].Selected)
                            {
                                listViewAuthor.Items[i].Remove();
                            }
                        }
                        MessageBox.Show("successfully", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failure", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("choose data to delete", "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

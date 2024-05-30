namespace LibaryOnline
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            tabControlDashboard = new TabControl();
            tabPageHome = new TabPage();
            label2 = new Label();
            label1 = new Label();
            tabPageAuthor = new TabPage();
            grActions = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBoxDatalist = new GroupBox();
            listViewAuthor = new ListView();
            groupBoxAuthor = new GroupBox();
            txtID = new TextBox();
            label13 = new Label();
            pictureBoxAvatar = new PictureBox();
            label12 = new Label();
            btnOpenFile = new Button();
            groupBoxgender = new GroupBox();
            radFemale = new RadioButton();
            radMal = new RadioButton();
            label11 = new Label();
            txtFileName = new TextBox();
            label10 = new Label();
            cboStatus = new ComboBox();
            label9 = new Label();
            txtbiography = new TextBox();
            label8 = new Label();
            txtAddress = new TextBox();
            label7 = new Label();
            dateBirthday = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            txtnickname = new TextBox();
            label4 = new Label();
            txtFullname = new TextBox();
            label3 = new Label();
            tabPageLogout = new TabPage();
            btnLogout = new Button();
            imageListicontab = new ImageList(components);
            openFileDialogAvatar = new OpenFileDialog();
            tabControlDashboard.SuspendLayout();
            tabPageHome.SuspendLayout();
            tabPageAuthor.SuspendLayout();
            grActions.SuspendLayout();
            groupBoxDatalist.SuspendLayout();
            groupBoxAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            groupBoxgender.SuspendLayout();
            tabPageLogout.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlDashboard
            // 
            tabControlDashboard.Controls.Add(tabPageHome);
            tabControlDashboard.Controls.Add(tabPageAuthor);
            tabControlDashboard.Controls.Add(tabPageLogout);
            tabControlDashboard.Dock = DockStyle.Fill;
            tabControlDashboard.ImageList = imageListicontab;
            tabControlDashboard.Location = new Point(0, 0);
            tabControlDashboard.Name = "tabControlDashboard";
            tabControlDashboard.SelectedIndex = 0;
            tabControlDashboard.Size = new Size(989, 949);
            tabControlDashboard.TabIndex = 0;
            tabControlDashboard.SelectedIndexChanged += tabControlDashboard_SelectedIndexChanged;
            // 
            // tabPageHome
            // 
            tabPageHome.Controls.Add(label2);
            tabPageHome.Controls.Add(label1);
            tabPageHome.ImageIndex = 2;
            tabPageHome.Location = new Point(4, 29);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(981, 916);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            tabPageHome.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(312, 78);
            label2.Name = "label2";
            label2.Size = new Size(185, 25);
            label2.TabIndex = 1;
            label2.Text = "Libary online software";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(331, 40);
            label1.Name = "label1";
            label1.Size = new Size(138, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // tabPageAuthor
            // 
            tabPageAuthor.Controls.Add(grActions);
            tabPageAuthor.Controls.Add(groupBoxDatalist);
            tabPageAuthor.Controls.Add(groupBoxAuthor);
            tabPageAuthor.ImageIndex = 0;
            tabPageAuthor.Location = new Point(4, 29);
            tabPageAuthor.Name = "tabPageAuthor";
            tabPageAuthor.Padding = new Padding(3);
            tabPageAuthor.Size = new Size(981, 916);
            tabPageAuthor.TabIndex = 1;
            tabPageAuthor.Text = "Author management";
            tabPageAuthor.UseVisualStyleBackColor = true;
            // 
            // grActions
            // 
            grActions.Controls.Add(btnDelete);
            grActions.Controls.Add(btnUpdate);
            grActions.Controls.Add(btnAdd);
            grActions.Location = new Point(24, 617);
            grActions.Name = "grActions";
            grActions.Size = new Size(917, 98);
            grActions.TabIndex = 2;
            grActions.TabStop = false;
            grActions.Text = "Actions";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(413, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 46);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(233, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(124, 46);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(52, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 46);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBoxDatalist
            // 
            groupBoxDatalist.Controls.Add(listViewAuthor);
            groupBoxDatalist.Location = new Point(24, 749);
            groupBoxDatalist.Name = "groupBoxDatalist";
            groupBoxDatalist.Size = new Size(923, 137);
            groupBoxDatalist.TabIndex = 1;
            groupBoxDatalist.TabStop = false;
            groupBoxDatalist.Text = "Data List";
            // 
            // listViewAuthor
            // 
            listViewAuthor.Location = new Point(22, 26);
            listViewAuthor.Name = "listViewAuthor";
            listViewAuthor.Size = new Size(876, 100);
            listViewAuthor.TabIndex = 0;
            listViewAuthor.UseCompatibleStateImageBehavior = false;
            listViewAuthor.SelectedIndexChanged += listViewAuthor_SelectedIndexChanged;
            // 
            // groupBoxAuthor
            // 
            groupBoxAuthor.Controls.Add(txtID);
            groupBoxAuthor.Controls.Add(label13);
            groupBoxAuthor.Controls.Add(pictureBoxAvatar);
            groupBoxAuthor.Controls.Add(label12);
            groupBoxAuthor.Controls.Add(btnOpenFile);
            groupBoxAuthor.Controls.Add(groupBoxgender);
            groupBoxAuthor.Controls.Add(label11);
            groupBoxAuthor.Controls.Add(txtFileName);
            groupBoxAuthor.Controls.Add(label10);
            groupBoxAuthor.Controls.Add(cboStatus);
            groupBoxAuthor.Controls.Add(label9);
            groupBoxAuthor.Controls.Add(txtbiography);
            groupBoxAuthor.Controls.Add(label8);
            groupBoxAuthor.Controls.Add(txtAddress);
            groupBoxAuthor.Controls.Add(label7);
            groupBoxAuthor.Controls.Add(dateBirthday);
            groupBoxAuthor.Controls.Add(label6);
            groupBoxAuthor.Controls.Add(label5);
            groupBoxAuthor.Controls.Add(txtnickname);
            groupBoxAuthor.Controls.Add(label4);
            groupBoxAuthor.Controls.Add(txtFullname);
            groupBoxAuthor.Controls.Add(label3);
            groupBoxAuthor.Location = new Point(8, 28);
            groupBoxAuthor.Name = "groupBoxAuthor";
            groupBoxAuthor.Size = new Size(940, 569);
            groupBoxAuthor.TabIndex = 0;
            groupBoxAuthor.TabStop = false;
            groupBoxAuthor.Text = "information";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(92, 59);
            txtID.Name = "txtID";
            txtID.Size = new Size(239, 27);
            txtID.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 57);
            label13.Name = "label13";
            label13.Size = new Size(24, 20);
            label13.TabIndex = 20;
            label13.Text = "ID";
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Location = new Point(520, 197);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(373, 229);
            pictureBoxAvatar.TabIndex = 19;
            pictureBoxAvatar.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(433, 198);
            label12.Name = "label12";
            label12.Size = new Size(51, 20);
            label12.TabIndex = 18;
            label12.Text = "Image";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(521, 137);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(372, 29);
            btnOpenFile.TabIndex = 17;
            btnOpenFile.Text = "OpenFile";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // groupBoxgender
            // 
            groupBoxgender.Controls.Add(radFemale);
            groupBoxgender.Controls.Add(radMal);
            groupBoxgender.Location = new Point(6, 245);
            groupBoxgender.Name = "groupBoxgender";
            groupBoxgender.Size = new Size(353, 64);
            groupBoxgender.TabIndex = 5;
            groupBoxgender.TabStop = false;
            groupBoxgender.Text = "Gender";
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(234, 26);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(78, 24);
            radFemale.TabIndex = 1;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // radMal
            // 
            radMal.AutoSize = true;
            radMal.Location = new Point(20, 26);
            radMal.Name = "radMal";
            radMal.Size = new Size(63, 24);
            radMal.TabIndex = 0;
            radMal.TabStop = true;
            radMal.Text = "Male";
            radMal.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(429, 141);
            label11.Name = "label11";
            label11.Size = new Size(81, 20);
            label11.TabIndex = 16;
            label11.Text = "ChooseFile";
            // 
            // txtFileName
            // 
            txtFileName.Enabled = false;
            txtFileName.Location = new Point(519, 90);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(374, 27);
            txtFileName.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(429, 92);
            label10.Name = "label10";
            label10.Size = new Size(72, 20);
            label10.TabIndex = 14;
            label10.Text = "FileName";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Active", "Deactive" });
            cboStatus.Location = new Point(98, 378);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(259, 28);
            cboStatus.TabIndex = 13;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 378);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 12;
            label9.Text = "Status";
            // 
            // txtbiography
            // 
            txtbiography.Location = new Point(98, 430);
            txtbiography.Multiline = true;
            txtbiography.Name = "txtbiography";
            txtbiography.Size = new Size(795, 104);
            txtbiography.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 430);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 10;
            label8.Text = "Biography";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(519, 39);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(374, 27);
            txtAddress.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(429, 46);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 8;
            label7.Text = "Address";
            // 
            // dateBirthday
            // 
            dateBirthday.Format = DateTimePickerFormat.Custom;
            dateBirthday.Location = new Point(98, 327);
            dateBirthday.Name = "dateBirthday";
            dateBirthday.Size = new Size(259, 27);
            dateBirthday.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 332);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 6;
            label6.Text = "Birthday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 133);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // txtnickname
            // 
            txtnickname.Location = new Point(90, 175);
            txtnickname.Name = "txtnickname";
            txtnickname.Size = new Size(275, 27);
            txtnickname.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 178);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 2;
            label4.Text = "NickName";
            label4.Click += label4_Click;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(92, 113);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(275, 27);
            txtFullname.TabIndex = 1;
            txtFullname.TextChanged += txtFullname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 113);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // tabPageLogout
            // 
            tabPageLogout.Controls.Add(btnLogout);
            tabPageLogout.ImageIndex = 1;
            tabPageLogout.Location = new Point(4, 29);
            tabPageLogout.Name = "tabPageLogout";
            tabPageLogout.Padding = new Padding(3);
            tabPageLogout.Size = new Size(981, 916);
            tabPageLogout.TabIndex = 2;
            tabPageLogout.Text = "Logout";
            tabPageLogout.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(247, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(173, 51);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Exit application";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // imageListicontab
            // 
            imageListicontab.ColorDepth = ColorDepth.Depth8Bit;
            imageListicontab.ImageStream = (ImageListStreamer)resources.GetObject("imageListicontab.ImageStream");
            imageListicontab.TransparentColor = Color.Transparent;
            imageListicontab.Images.SetKeyName(0, "icons8-author-20.png");
            imageListicontab.Images.SetKeyName(1, "icons8-exit-20.png");
            imageListicontab.Images.SetKeyName(2, "icons8-home-20.png");
            // 
            // openFileDialogAvatar
            // 
            openFileDialogAvatar.FileName = "openFileDialog1";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 949);
            Controls.Add(tabControlDashboard);
            Name = "FormDashboard";
            Text = "FormDashboard";
            Load += FormDashboard_Load;
            tabControlDashboard.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tabPageHome.PerformLayout();
            tabPageAuthor.ResumeLayout(false);
            grActions.ResumeLayout(false);
            groupBoxDatalist.ResumeLayout(false);
            groupBoxAuthor.ResumeLayout(false);
            groupBoxAuthor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            groupBoxgender.ResumeLayout(false);
            groupBoxgender.PerformLayout();
            tabPageLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlDashboard;
        private TabPage tabPageHome;
        private TabPage tabPageAuthor;
        private Label label2;
        private Label label1;
        private TabPage tabPageLogout;
        private Button btnLogout;
        private ImageList imageListicontab;
        private GroupBox groupBoxAuthor;
        private Label label4;
        private TextBox txtFullname;
        private Label label3;
        private TextBox txtnickname;
        private Label label6;
        private GroupBox groupBoxgender;
        private RadioButton radFemale;
        private RadioButton radMal;
        private Label label5;
        private Label label9;
        private TextBox txtbiography;
        private Label label8;
        private TextBox txtAddress;
        private Label label7;
        private DateTimePicker dateBirthday;
        private TextBox txtFileName;
        private Label label10;
        private ComboBox cboStatus;
        private PictureBox pictureBoxAvatar;
        private Label label12;
        private Button btnOpenFile;
        private Label label11;
        private GroupBox groupBoxDatalist;
        private ListView listViewAuthor;
        private OpenFileDialog openFileDialogAvatar;
        private GroupBox grActions;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtID;
        private Label label13;
        private Button btnDelete;
    }
}
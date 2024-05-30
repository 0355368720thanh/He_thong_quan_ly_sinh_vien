namespace CMS
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            openFileDialogAvatar = new OpenFileDialog();
            imageListicontab = new ImageList(components);
            tabControlDashboard = new TabControl();
            tabPageHome = new TabPage();
            tabPageStudent = new TabPage();
            groupBox11 = new GroupBox();
            listViewStu = new ListView();
            groupBox12 = new GroupBox();
            btnDeStu = new Button();
            btnUpStu = new Button();
            btnAddStu = new Button();
            groupBox13 = new GroupBox();
            cboCourses = new ComboBox();
            label2 = new Label();
            pictureBoxStu = new PictureBox();
            btnOpen = new Button();
            txtFile = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label22 = new Label();
            groupBox14 = new GroupBox();
            radFemStu = new RadioButton();
            radMaleStu = new RadioButton();
            BirthStu = new DateTimePicker();
            txtEmailStu = new TextBox();
            txtAddStu = new TextBox();
            txtPhoneStu = new TextBox();
            txtNameStu = new TextBox();
            txtStudent = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            tabPageInstructor = new TabPage();
            groupBox15 = new GroupBox();
            listViewIns = new ListView();
            groupBox16 = new GroupBox();
            btnDeIns = new Button();
            btnUpIns = new Button();
            btnAddIns = new Button();
            groupBox17 = new GroupBox();
            cboIns = new ComboBox();
            label29 = new Label();
            groupBox18 = new GroupBox();
            radFemIn = new RadioButton();
            radMaleIn = new RadioButton();
            BirthIns = new DateTimePicker();
            txtEmailIns = new TextBox();
            txtAddressIns = new TextBox();
            txtphoneIns = new TextBox();
            txtNameIns = new TextBox();
            txtIns = new TextBox();
            label30 = new Label();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            tabPageCourse = new TabPage();
            flowLayoutPanelCourses = new FlowLayoutPanel();
            btnRemovecourse = new Button();
            btnCours = new Button();
            txtCour = new TextBox();
            label37 = new Label();
            tabPageGrades = new TabPage();
            groupBox19 = new GroupBox();
            dgvGrade = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            AssignmentName = new DataGridViewTextBoxColumn();
            groupBox20 = new GroupBox();
            btnreset = new Button();
            cboSeach = new ComboBox();
            btnSea = new Button();
            label1 = new Label();
            label38 = new Label();
            txtStuID = new TextBox();
            tabPageLogout = new TabPage();
            btnExit = new Button();
            tabControlDashboard.SuspendLayout();
            tabPageStudent.SuspendLayout();
            groupBox11.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStu).BeginInit();
            groupBox14.SuspendLayout();
            tabPageInstructor.SuspendLayout();
            groupBox15.SuspendLayout();
            groupBox16.SuspendLayout();
            groupBox17.SuspendLayout();
            groupBox18.SuspendLayout();
            tabPageCourse.SuspendLayout();
            tabPageGrades.SuspendLayout();
            groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrade).BeginInit();
            groupBox20.SuspendLayout();
            tabPageLogout.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogAvatar
            // 
            openFileDialogAvatar.FileName = "openFileDialogAvatar";
            // 
            // imageListicontab
            // 
            imageListicontab.ColorDepth = ColorDepth.Depth8Bit;
            imageListicontab.ImageStream = (ImageListStreamer)resources.GetObject("imageListicontab.ImageStream");
            imageListicontab.TransparentColor = Color.Transparent;
            imageListicontab.Images.SetKeyName(0, "icons8-assignment-20.png");
            imageListicontab.Images.SetKeyName(1, "icons8-course-20.png");
            imageListicontab.Images.SetKeyName(2, "icons8-home-20.png");
            imageListicontab.Images.SetKeyName(3, "icons8-login-20.png");
            imageListicontab.Images.SetKeyName(4, "icons8-student-20.png");
            imageListicontab.Images.SetKeyName(5, "icons8-instructor-20.png");
            imageListicontab.Images.SetKeyName(6, "icons8-exit-20.png");
            imageListicontab.Images.SetKeyName(7, "icons8-grades-20.png");
            // 
            // tabControlDashboard
            // 
            tabControlDashboard.Controls.Add(tabPageHome);
            tabControlDashboard.Controls.Add(tabPageStudent);
            tabControlDashboard.Controls.Add(tabPageInstructor);
            tabControlDashboard.Controls.Add(tabPageCourse);
            tabControlDashboard.Controls.Add(tabPageGrades);
            tabControlDashboard.Controls.Add(tabPageLogout);
            tabControlDashboard.Dock = DockStyle.Fill;
            tabControlDashboard.HotTrack = true;
            tabControlDashboard.ImageList = imageListicontab;
            tabControlDashboard.Location = new Point(0, 0);
            tabControlDashboard.Multiline = true;
            tabControlDashboard.Name = "tabControlDashboard";
            tabControlDashboard.SelectedIndex = 0;
            tabControlDashboard.Size = new Size(856, 873);
            tabControlDashboard.TabIndex = 4;
            tabControlDashboard.SelectedIndexChanged += tabControlDashboard_SelectedIndexChanged;
            // 
            // tabPageHome
            // 
            tabPageHome.BackColor = Color.Transparent;
            tabPageHome.BackgroundImage = (Image)resources.GetObject("tabPageHome.BackgroundImage");
            tabPageHome.ImageIndex = 2;
            tabPageHome.Location = new Point(4, 29);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(848, 840);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            // 
            // tabPageStudent
            // 
            tabPageStudent.BackColor = Color.Black;
            tabPageStudent.Controls.Add(groupBox11);
            tabPageStudent.Controls.Add(groupBox12);
            tabPageStudent.Controls.Add(groupBox13);
            tabPageStudent.ImageIndex = 4;
            tabPageStudent.Location = new Point(4, 29);
            tabPageStudent.Name = "tabPageStudent";
            tabPageStudent.Padding = new Padding(3);
            tabPageStudent.Size = new Size(848, 840);
            tabPageStudent.TabIndex = 1;
            tabPageStudent.Text = "Student";
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(listViewStu);
            groupBox11.ForeColor = SystemColors.ButtonFace;
            groupBox11.Location = new Point(25, 587);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(830, 201);
            groupBox11.TabIndex = 2;
            groupBox11.TabStop = false;
            groupBox11.Text = "Datalist";
            // 
            // listViewStu
            // 
            listViewStu.Location = new Point(21, 35);
            listViewStu.Name = "listViewStu";
            listViewStu.Size = new Size(786, 142);
            listViewStu.TabIndex = 0;
            listViewStu.UseCompatibleStateImageBehavior = false;
            listViewStu.SelectedIndexChanged += listViewStu_SelectedIndexChanged;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(btnDeStu);
            groupBox12.Controls.Add(btnUpStu);
            groupBox12.Controls.Add(btnAddStu);
            groupBox12.ForeColor = SystemColors.Control;
            groupBox12.Location = new Point(25, 454);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(830, 103);
            groupBox12.TabIndex = 1;
            groupBox12.TabStop = false;
            groupBox12.Text = "Actions";
            // 
            // btnDeStu
            // 
            btnDeStu.BackColor = Color.OrangeRed;
            btnDeStu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeStu.ForeColor = SystemColors.Control;
            btnDeStu.Location = new Point(533, 26);
            btnDeStu.Name = "btnDeStu";
            btnDeStu.Size = new Size(135, 61);
            btnDeStu.TabIndex = 2;
            btnDeStu.Text = "Delete";
            btnDeStu.UseVisualStyleBackColor = false;
            btnDeStu.Click += btnDeStu_Click;
            // 
            // btnUpStu
            // 
            btnUpStu.BackColor = Color.OrangeRed;
            btnUpStu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpStu.ForeColor = SystemColors.Control;
            btnUpStu.Location = new Point(304, 26);
            btnUpStu.Name = "btnUpStu";
            btnUpStu.Size = new Size(127, 61);
            btnUpStu.TabIndex = 1;
            btnUpStu.Text = "Update";
            btnUpStu.UseVisualStyleBackColor = false;
            btnUpStu.Click += btnUpStu_Click;
            // 
            // btnAddStu
            // 
            btnAddStu.BackColor = Color.OrangeRed;
            btnAddStu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddStu.ForeColor = SystemColors.Control;
            btnAddStu.Location = new Point(74, 26);
            btnAddStu.Name = "btnAddStu";
            btnAddStu.Size = new Size(129, 61);
            btnAddStu.TabIndex = 0;
            btnAddStu.Text = "Add";
            btnAddStu.UseVisualStyleBackColor = false;
            btnAddStu.Click += btnAddStu_Click;
            // 
            // groupBox13
            // 
            groupBox13.Controls.Add(cboCourses);
            groupBox13.Controls.Add(label2);
            groupBox13.Controls.Add(pictureBoxStu);
            groupBox13.Controls.Add(btnOpen);
            groupBox13.Controls.Add(txtFile);
            groupBox13.Controls.Add(label11);
            groupBox13.Controls.Add(label12);
            groupBox13.Controls.Add(label22);
            groupBox13.Controls.Add(groupBox14);
            groupBox13.Controls.Add(BirthStu);
            groupBox13.Controls.Add(txtEmailStu);
            groupBox13.Controls.Add(txtAddStu);
            groupBox13.Controls.Add(txtPhoneStu);
            groupBox13.Controls.Add(txtNameStu);
            groupBox13.Controls.Add(txtStudent);
            groupBox13.Controls.Add(label23);
            groupBox13.Controls.Add(label24);
            groupBox13.Controls.Add(label25);
            groupBox13.Controls.Add(label26);
            groupBox13.Controls.Add(label27);
            groupBox13.Controls.Add(label28);
            groupBox13.ForeColor = Color.White;
            groupBox13.Location = new Point(25, 16);
            groupBox13.Name = "groupBox13";
            groupBox13.Size = new Size(830, 415);
            groupBox13.TabIndex = 0;
            groupBox13.TabStop = false;
            groupBox13.Text = "Infomation";
            // 
            // cboCourses
            // 
            cboCourses.FormattingEnabled = true;
            cboCourses.Location = new Point(147, 288);
            cboCourses.Name = "cboCourses";
            cboCourses.Size = new Size(249, 28);
            cboCourses.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 285);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 19;
            label2.Text = "Course";
            // 
            // pictureBoxStu
            // 
            pictureBoxStu.Location = new Point(565, 158);
            pictureBoxStu.Name = "pictureBoxStu";
            pictureBoxStu.Size = new Size(242, 193);
            pictureBoxStu.TabIndex = 18;
            pictureBoxStu.TabStop = false;
            // 
            // btnOpen
            // 
            btnOpen.ForeColor = Color.Black;
            btnOpen.Location = new Point(559, 88);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(248, 29);
            btnOpen.TabIndex = 17;
            btnOpen.Text = "OpenFile";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // txtFile
            // 
            txtFile.Enabled = false;
            txtFile.Location = new Point(559, 37);
            txtFile.Name = "txtFile";
            txtFile.Size = new Size(248, 27);
            txtFile.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(476, 155);
            label11.Name = "label11";
            label11.Size = new Size(62, 25);
            label11.TabIndex = 15;
            label11.Text = "Image";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(456, 86);
            label12.Name = "label12";
            label12.Size = new Size(98, 25);
            label12.TabIndex = 14;
            label12.Text = "ChooseFile";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(456, 44);
            label22.Name = "label22";
            label22.Size = new Size(82, 25);
            label22.TabIndex = 13;
            label22.Text = "Filename";
            // 
            // groupBox14
            // 
            groupBox14.Controls.Add(radFemStu);
            groupBox14.Controls.Add(radMaleStu);
            groupBox14.ForeColor = Color.White;
            groupBox14.Location = new Point(43, 319);
            groupBox14.Name = "groupBox14";
            groupBox14.Size = new Size(354, 80);
            groupBox14.TabIndex = 12;
            groupBox14.TabStop = false;
            groupBox14.Text = "Gender";
            // 
            // radFemStu
            // 
            radFemStu.AutoSize = true;
            radFemStu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radFemStu.Location = new Point(212, 26);
            radFemStu.Name = "radFemStu";
            radFemStu.Size = new Size(89, 29);
            radFemStu.TabIndex = 1;
            radFemStu.TabStop = true;
            radFemStu.Text = "Female";
            radFemStu.UseVisualStyleBackColor = true;
            // 
            // radMaleStu
            // 
            radMaleStu.AutoSize = true;
            radMaleStu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radMaleStu.Location = new Point(82, 26);
            radMaleStu.Name = "radMaleStu";
            radMaleStu.Size = new Size(71, 29);
            radMaleStu.TabIndex = 0;
            radMaleStu.TabStop = true;
            radMaleStu.Text = "Male";
            radMaleStu.UseVisualStyleBackColor = true;
            // 
            // BirthStu
            // 
            BirthStu.Location = new Point(149, 240);
            BirthStu.Name = "BirthStu";
            BirthStu.Size = new Size(250, 27);
            BirthStu.TabIndex = 11;
            // 
            // txtEmailStu
            // 
            txtEmailStu.Location = new Point(149, 195);
            txtEmailStu.Name = "txtEmailStu";
            txtEmailStu.Size = new Size(247, 27);
            txtEmailStu.TabIndex = 10;
            // 
            // txtAddStu
            // 
            txtAddStu.Location = new Point(149, 155);
            txtAddStu.Name = "txtAddStu";
            txtAddStu.Size = new Size(194, 27);
            txtAddStu.TabIndex = 9;
            // 
            // txtPhoneStu
            // 
            txtPhoneStu.Location = new Point(149, 112);
            txtPhoneStu.Name = "txtPhoneStu";
            txtPhoneStu.Size = new Size(144, 27);
            txtPhoneStu.TabIndex = 8;
            txtPhoneStu.KeyPress += txtPhoneStu_KeyPress;
            // 
            // txtNameStu
            // 
            txtNameStu.Location = new Point(149, 76);
            txtNameStu.Name = "txtNameStu";
            txtNameStu.Size = new Size(211, 27);
            txtNameStu.TabIndex = 7;
            // 
            // txtStudent
            // 
            txtStudent.Enabled = false;
            txtStudent.Location = new Point(149, 37);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(161, 27);
            txtStudent.TabIndex = 6;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(43, 240);
            label23.Name = "label23";
            label23.Size = new Size(77, 25);
            label23.TabIndex = 5;
            label23.Text = "Birthday";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(42, 202);
            label24.Name = "label24";
            label24.Size = new Size(54, 25);
            label24.TabIndex = 4;
            label24.Text = "Email";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(42, 155);
            label25.Name = "label25";
            label25.Size = new Size(77, 25);
            label25.TabIndex = 3;
            label25.Text = "Address";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(43, 112);
            label26.Name = "label26";
            label26.Size = new Size(62, 25);
            label26.TabIndex = 2;
            label26.Text = "Phone";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(42, 79);
            label27.Name = "label27";
            label27.Size = new Size(86, 25);
            label27.TabIndex = 1;
            label27.Text = "FullName";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(43, 41);
            label28.Name = "label28";
            label28.Size = new Size(27, 23);
            label28.TabIndex = 0;
            label28.Text = "ID";
            // 
            // tabPageInstructor
            // 
            tabPageInstructor.BackColor = Color.Black;
            tabPageInstructor.Controls.Add(groupBox15);
            tabPageInstructor.Controls.Add(groupBox16);
            tabPageInstructor.Controls.Add(groupBox17);
            tabPageInstructor.ImageIndex = 5;
            tabPageInstructor.Location = new Point(4, 29);
            tabPageInstructor.Name = "tabPageInstructor";
            tabPageInstructor.Padding = new Padding(3);
            tabPageInstructor.Size = new Size(848, 840);
            tabPageInstructor.TabIndex = 2;
            tabPageInstructor.Text = "Instructor";
            // 
            // groupBox15
            // 
            groupBox15.Controls.Add(listViewIns);
            groupBox15.ForeColor = SystemColors.ButtonFace;
            groupBox15.Location = new Point(25, 483);
            groupBox15.Name = "groupBox15";
            groupBox15.Size = new Size(830, 289);
            groupBox15.TabIndex = 4;
            groupBox15.TabStop = false;
            groupBox15.Text = "Datalist";
            // 
            // listViewIns
            // 
            listViewIns.Location = new Point(15, 26);
            listViewIns.Name = "listViewIns";
            listViewIns.Size = new Size(792, 241);
            listViewIns.TabIndex = 0;
            listViewIns.UseCompatibleStateImageBehavior = false;
            listViewIns.SelectedIndexChanged += listViewIns_SelectedIndexChanged;
            // 
            // groupBox16
            // 
            groupBox16.Controls.Add(btnDeIns);
            groupBox16.Controls.Add(btnUpIns);
            groupBox16.Controls.Add(btnAddIns);
            groupBox16.ForeColor = SystemColors.Control;
            groupBox16.Location = new Point(484, 20);
            groupBox16.Name = "groupBox16";
            groupBox16.Size = new Size(371, 457);
            groupBox16.TabIndex = 3;
            groupBox16.TabStop = false;
            groupBox16.Text = "Actions";
            // 
            // btnDeIns
            // 
            btnDeIns.BackColor = Color.OrangeRed;
            btnDeIns.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeIns.ForeColor = SystemColors.Control;
            btnDeIns.Location = new Point(29, 319);
            btnDeIns.Name = "btnDeIns";
            btnDeIns.Size = new Size(319, 114);
            btnDeIns.TabIndex = 2;
            btnDeIns.Text = "Delete";
            btnDeIns.UseVisualStyleBackColor = false;
            btnDeIns.Click += btnDeIns_Click;
            // 
            // btnUpIns
            // 
            btnUpIns.BackColor = Color.OrangeRed;
            btnUpIns.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpIns.ForeColor = SystemColors.Control;
            btnUpIns.Location = new Point(29, 166);
            btnUpIns.Name = "btnUpIns";
            btnUpIns.Size = new Size(319, 120);
            btnUpIns.TabIndex = 1;
            btnUpIns.Text = "Update";
            btnUpIns.UseVisualStyleBackColor = false;
            btnUpIns.Click += btnUpIns_Click;
            // 
            // btnAddIns
            // 
            btnAddIns.BackColor = Color.OrangeRed;
            btnAddIns.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddIns.ForeColor = SystemColors.Control;
            btnAddIns.Location = new Point(29, 26);
            btnAddIns.Name = "btnAddIns";
            btnAddIns.Size = new Size(319, 105);
            btnAddIns.TabIndex = 0;
            btnAddIns.Text = "Add";
            btnAddIns.UseVisualStyleBackColor = false;
            btnAddIns.Click += btnAddIns_Click;
            // 
            // groupBox17
            // 
            groupBox17.Controls.Add(cboIns);
            groupBox17.Controls.Add(label29);
            groupBox17.Controls.Add(groupBox18);
            groupBox17.Controls.Add(BirthIns);
            groupBox17.Controls.Add(txtEmailIns);
            groupBox17.Controls.Add(txtAddressIns);
            groupBox17.Controls.Add(txtphoneIns);
            groupBox17.Controls.Add(txtNameIns);
            groupBox17.Controls.Add(txtIns);
            groupBox17.Controls.Add(label30);
            groupBox17.Controls.Add(label31);
            groupBox17.Controls.Add(label32);
            groupBox17.Controls.Add(label33);
            groupBox17.Controls.Add(label34);
            groupBox17.Controls.Add(label35);
            groupBox17.ForeColor = Color.White;
            groupBox17.Location = new Point(25, 20);
            groupBox17.Name = "groupBox17";
            groupBox17.Size = new Size(453, 457);
            groupBox17.TabIndex = 2;
            groupBox17.TabStop = false;
            groupBox17.Text = "Infomation";
            // 
            // cboIns
            // 
            cboIns.FormattingEnabled = true;
            cboIns.Items.AddRange(new object[] { "Maketing", "IT", "Design" });
            cboIns.Location = new Point(148, 303);
            cboIns.Name = "cboIns";
            cboIns.Size = new Size(195, 28);
            cboIns.TabIndex = 14;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(43, 306);
            label29.Name = "label29";
            label29.Size = new Size(99, 25);
            label29.TabIndex = 13;
            label29.Text = "Specialized";
            // 
            // groupBox18
            // 
            groupBox18.Controls.Add(radFemIn);
            groupBox18.Controls.Add(radMaleIn);
            groupBox18.ForeColor = Color.White;
            groupBox18.Location = new Point(42, 353);
            groupBox18.Name = "groupBox18";
            groupBox18.Size = new Size(354, 80);
            groupBox18.TabIndex = 12;
            groupBox18.TabStop = false;
            groupBox18.Text = "Gender";
            // 
            // radFemIn
            // 
            radFemIn.AutoSize = true;
            radFemIn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radFemIn.Location = new Point(223, 37);
            radFemIn.Name = "radFemIn";
            radFemIn.Size = new Size(89, 29);
            radFemIn.TabIndex = 1;
            radFemIn.TabStop = true;
            radFemIn.Text = "Female";
            radFemIn.UseVisualStyleBackColor = true;
            // 
            // radMaleIn
            // 
            radMaleIn.AutoSize = true;
            radMaleIn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radMaleIn.Location = new Point(81, 37);
            radMaleIn.Name = "radMaleIn";
            radMaleIn.Size = new Size(71, 29);
            radMaleIn.TabIndex = 0;
            radMaleIn.TabStop = true;
            radMaleIn.Text = "Male";
            radMaleIn.UseVisualStyleBackColor = true;
            // 
            // BirthIns
            // 
            BirthIns.Location = new Point(146, 252);
            BirthIns.Name = "BirthIns";
            BirthIns.Size = new Size(250, 27);
            BirthIns.TabIndex = 11;
            // 
            // txtEmailIns
            // 
            txtEmailIns.Location = new Point(149, 207);
            txtEmailIns.Name = "txtEmailIns";
            txtEmailIns.Size = new Size(247, 27);
            txtEmailIns.TabIndex = 10;
            // 
            // txtAddressIns
            // 
            txtAddressIns.Location = new Point(149, 166);
            txtAddressIns.Name = "txtAddressIns";
            txtAddressIns.Size = new Size(194, 27);
            txtAddressIns.TabIndex = 9;
            // 
            // txtphoneIns
            // 
            txtphoneIns.Location = new Point(149, 121);
            txtphoneIns.Name = "txtphoneIns";
            txtphoneIns.Size = new Size(140, 27);
            txtphoneIns.TabIndex = 8;
            txtphoneIns.KeyPress += txtphoneIns_KeyPress;
            // 
            // txtNameIns
            // 
            txtNameIns.Location = new Point(149, 76);
            txtNameIns.Name = "txtNameIns";
            txtNameIns.Size = new Size(211, 27);
            txtNameIns.TabIndex = 7;
            // 
            // txtIns
            // 
            txtIns.Enabled = false;
            txtIns.Location = new Point(149, 37);
            txtIns.Name = "txtIns";
            txtIns.Size = new Size(161, 27);
            txtIns.TabIndex = 6;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(43, 252);
            label30.Name = "label30";
            label30.Size = new Size(77, 25);
            label30.TabIndex = 5;
            label30.Text = "Birthday";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(42, 207);
            label31.Name = "label31";
            label31.Size = new Size(54, 25);
            label31.TabIndex = 4;
            label31.Text = "Email";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label32.Location = new Point(42, 166);
            label32.Name = "label32";
            label32.Size = new Size(77, 25);
            label32.TabIndex = 3;
            label32.Text = "Address";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label33.Location = new Point(43, 121);
            label33.Name = "label33";
            label33.Size = new Size(62, 25);
            label33.TabIndex = 2;
            label33.Text = "Phone";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label34.Location = new Point(42, 79);
            label34.Name = "label34";
            label34.Size = new Size(86, 25);
            label34.TabIndex = 1;
            label34.Text = "FullName";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label35.Location = new Point(42, 40);
            label35.Name = "label35";
            label35.Size = new Size(30, 25);
            label35.TabIndex = 0;
            label35.Text = "ID";
            // 
            // tabPageCourse
            // 
            tabPageCourse.BackColor = Color.Black;
            tabPageCourse.Controls.Add(flowLayoutPanelCourses);
            tabPageCourse.Controls.Add(btnRemovecourse);
            tabPageCourse.Controls.Add(btnCours);
            tabPageCourse.Controls.Add(txtCour);
            tabPageCourse.Controls.Add(label37);
            tabPageCourse.ImageIndex = 1;
            tabPageCourse.Location = new Point(4, 29);
            tabPageCourse.Name = "tabPageCourse";
            tabPageCourse.Padding = new Padding(3);
            tabPageCourse.Size = new Size(848, 840);
            tabPageCourse.TabIndex = 3;
            tabPageCourse.Text = "Course";
            // 
            // flowLayoutPanelCourses
            // 
            flowLayoutPanelCourses.Location = new Point(0, 260);
            flowLayoutPanelCourses.Name = "flowLayoutPanelCourses";
            flowLayoutPanelCourses.Size = new Size(852, 584);
            flowLayoutPanelCourses.TabIndex = 7;
            // 
            // btnRemovecourse
            // 
            btnRemovecourse.BackColor = Color.OrangeRed;
            btnRemovecourse.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemovecourse.Location = new Point(563, 63);
            btnRemovecourse.Name = "btnRemovecourse";
            btnRemovecourse.Size = new Size(135, 109);
            btnRemovecourse.TabIndex = 6;
            btnRemovecourse.Text = "RemoveCourse";
            btnRemovecourse.UseVisualStyleBackColor = false;
            btnRemovecourse.Click += btnRemovecourse_Click;
            // 
            // btnCours
            // 
            btnCours.BackColor = Color.OrangeRed;
            btnCours.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCours.ImageAlign = ContentAlignment.TopLeft;
            btnCours.Location = new Point(199, 116);
            btnCours.Name = "btnCours";
            btnCours.Size = new Size(316, 56);
            btnCours.TabIndex = 5;
            btnCours.Text = "AddCourses";
            btnCours.UseVisualStyleBackColor = false;
            btnCours.Click += btnCours_Click;
            // 
            // txtCour
            // 
            txtCour.Location = new Point(199, 67);
            txtCour.Name = "txtCour";
            txtCour.Size = new Size(316, 27);
            txtCour.TabIndex = 3;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label37.ForeColor = SystemColors.Control;
            label37.Location = new Point(63, 63);
            label37.Name = "label37";
            label37.Size = new Size(124, 28);
            label37.TabIndex = 1;
            label37.Text = "CourseName";
            // 
            // tabPageGrades
            // 
            tabPageGrades.BackColor = Color.Black;
            tabPageGrades.Controls.Add(groupBox19);
            tabPageGrades.Controls.Add(groupBox20);
            tabPageGrades.ImageIndex = 7;
            tabPageGrades.Location = new Point(4, 29);
            tabPageGrades.Name = "tabPageGrades";
            tabPageGrades.Padding = new Padding(3);
            tabPageGrades.Size = new Size(848, 840);
            tabPageGrades.TabIndex = 4;
            tabPageGrades.Text = "Grades";
            // 
            // groupBox19
            // 
            groupBox19.Controls.Add(dgvGrade);
            groupBox19.ForeColor = Color.Black;
            groupBox19.Location = new Point(3, 290);
            groupBox19.Name = "groupBox19";
            groupBox19.Size = new Size(860, 482);
            groupBox19.TabIndex = 8;
            groupBox19.TabStop = false;
            // 
            // dgvGrade
            // 
            dgvGrade.AllowUserToAddRows = false;
            dgvGrade.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvGrade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvGrade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvGrade.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrade.Columns.AddRange(new DataGridViewColumn[] { StudentID, FullName, Score, AssignmentName });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvGrade.DefaultCellStyle = dataGridViewCellStyle6;
            dgvGrade.Location = new Point(8, 26);
            dgvGrade.Name = "dgvGrade";
            dgvGrade.ReadOnly = true;
            dgvGrade.RowHeadersWidth = 51;
            dgvGrade.RowTemplate.Height = 29;
            dgvGrade.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrade.Size = new Size(831, 450);
            dgvGrade.TabIndex = 0;
            // 
            // StudentID
            // 
            StudentID.DataPropertyName = "StudentID";
            StudentID.Frozen = true;
            StudentID.HeaderText = "ID";
            StudentID.MinimumWidth = 6;
            StudentID.Name = "StudentID";
            StudentID.ReadOnly = true;
            StudentID.Width = 50;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.Frozen = true;
            FullName.HeaderText = "Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 240;
            // 
            // Score
            // 
            Score.DataPropertyName = "Score";
            Score.Frozen = true;
            Score.HeaderText = "Score";
            Score.MinimumWidth = 6;
            Score.Name = "Score";
            Score.ReadOnly = true;
            Score.Width = 120;
            // 
            // AssignmentName
            // 
            AssignmentName.DataPropertyName = "AssignmentName";
            AssignmentName.Frozen = true;
            AssignmentName.HeaderText = "Assignment Name";
            AssignmentName.MinimumWidth = 6;
            AssignmentName.Name = "AssignmentName";
            AssignmentName.ReadOnly = true;
            AssignmentName.Width = 400;
            // 
            // groupBox20
            // 
            groupBox20.Controls.Add(btnreset);
            groupBox20.Controls.Add(cboSeach);
            groupBox20.Controls.Add(btnSea);
            groupBox20.Controls.Add(label1);
            groupBox20.Controls.Add(label38);
            groupBox20.Controls.Add(txtStuID);
            groupBox20.ForeColor = Color.White;
            groupBox20.Location = new Point(8, 27);
            groupBox20.Name = "groupBox20";
            groupBox20.Size = new Size(855, 231);
            groupBox20.TabIndex = 7;
            groupBox20.TabStop = false;
            groupBox20.Text = "Infomation";
            // 
            // btnreset
            // 
            btnreset.ForeColor = Color.Black;
            btnreset.Location = new Point(679, 124);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(110, 63);
            btnreset.TabIndex = 6;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // cboSeach
            // 
            cboSeach.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeach.FormattingEnabled = true;
            cboSeach.Items.AddRange(new object[] { "Student ID", "Name" });
            cboSeach.Location = new Point(146, 62);
            cboSeach.Name = "cboSeach";
            cboSeach.Size = new Size(103, 28);
            cboSeach.TabIndex = 5;
            // 
            // btnSea
            // 
            btnSea.BackColor = Color.OrangeRed;
            btnSea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSea.ForeColor = SystemColors.Control;
            btnSea.Location = new Point(371, 124);
            btnSea.Name = "btnSea";
            btnSea.Size = new Size(243, 63);
            btnSea.TabIndex = 4;
            btnSea.Text = "Search";
            btnSea.UseVisualStyleBackColor = false;
            btnSea.Click += btnSea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 59);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 0;
            label1.Text = "For search";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label38.ForeColor = Color.White;
            label38.Location = new Point(265, 59);
            label38.Name = "label38";
            label38.Size = new Size(70, 28);
            label38.TabIndex = 0;
            label38.Text = "Search";
            // 
            // txtStuID
            // 
            txtStuID.Location = new Point(371, 63);
            txtStuID.Name = "txtStuID";
            txtStuID.Size = new Size(243, 27);
            txtStuID.TabIndex = 2;
            txtStuID.TextChanged += txtStuID_TextChanged;
            // 
            // tabPageLogout
            // 
            tabPageLogout.BackColor = Color.Black;
            tabPageLogout.BackgroundImage = Properties.Resources.tải_xuống;
            tabPageLogout.Controls.Add(btnExit);
            tabPageLogout.ImageIndex = 6;
            tabPageLogout.Location = new Point(4, 29);
            tabPageLogout.Name = "tabPageLogout";
            tabPageLogout.Padding = new Padding(3);
            tabPageLogout.Size = new Size(848, 840);
            tabPageLogout.TabIndex = 5;
            tabPageLogout.Text = "Logout";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(217, 418);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(349, 75);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 873);
            Controls.Add(tabControlDashboard);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            tabControlDashboard.ResumeLayout(false);
            tabPageStudent.ResumeLayout(false);
            groupBox11.ResumeLayout(false);
            groupBox12.ResumeLayout(false);
            groupBox13.ResumeLayout(false);
            groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxStu).EndInit();
            groupBox14.ResumeLayout(false);
            groupBox14.PerformLayout();
            tabPageInstructor.ResumeLayout(false);
            groupBox15.ResumeLayout(false);
            groupBox16.ResumeLayout(false);
            groupBox17.ResumeLayout(false);
            groupBox17.PerformLayout();
            groupBox18.ResumeLayout(false);
            groupBox18.PerformLayout();
            tabPageCourse.ResumeLayout(false);
            tabPageCourse.PerformLayout();
            tabPageGrades.ResumeLayout(false);
            groupBox19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvGrade).EndInit();
            groupBox20.ResumeLayout(false);
            groupBox20.PerformLayout();
            tabPageLogout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogAvatar;
        private ImageList imageListicontab;
        private TabControl tabControlDashboard;
        private TabPage tabPageHome;
        private TabPage tabPageStudent;
        private GroupBox groupBox11;
        private ListView listViewStu;
        private GroupBox groupBox12;
        private Button btnDeStu;
        private Button btnUpStu;
        private Button btnAddStu;
        private GroupBox groupBox13;
        private PictureBox pictureBoxStu;
        private Button btnOpen;
        private TextBox txtFile;
        private Label label11;
        private Label label12;
        private Label label22;
        private GroupBox groupBox14;
        private RadioButton radFemStu;
        private RadioButton radMaleStu;
        private DateTimePicker BirthStu;
        private TextBox txtEmailStu;
        private TextBox txtAddStu;
        private TextBox txtPhoneStu;
        private TextBox txtNameStu;
        private TextBox txtStudent;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private TabPage tabPageInstructor;
        private GroupBox groupBox15;
        private ListView listViewIns;
        private GroupBox groupBox16;
        private Button btnDeIns;
        private Button btnUpIns;
        private Button btnAddIns;
        private GroupBox groupBox17;
        private ComboBox cboIns;
        private Label label29;
        private GroupBox groupBox18;
        private RadioButton radFemIn;
        private RadioButton radMaleIn;
        private DateTimePicker BirthIns;
        private TextBox txtEmailIns;
        private TextBox txtAddressIns;
        private TextBox txtphoneIns;
        private TextBox txtNameIns;
        private TextBox txtIns;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private TabPage tabPageCourse;
        private Button btnRemovecourse;
        private Button btnCours;
        private TextBox txtCour;
        private Label label37;
        private TabPage tabPageGrades;
        private GroupBox groupBox19;
        private GroupBox groupBox20;
        private Button btnSea;
        private Label label38;
        private TextBox txtStuID;
        private TabPage tabPageLogout;
        private Button btnExit;
        private FlowLayoutPanel flowLayoutPanelCourses;
        private ComboBox cboSeach;
        private Label label1;
        private DataGridView dgvGrade;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn AssignmentName;
        private Button btnreset;
        private Label label2;
        private ComboBox cboCourses;
    }
}
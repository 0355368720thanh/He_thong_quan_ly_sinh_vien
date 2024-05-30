namespace LibaryOnline
{
    partial class categoriesform
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
            btnback = new Button();
            groupBox1 = new GroupBox();
            cboStatus = new ComboBox();
            label3 = new Label();
            txtdes = new TextBox();
            txtname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btndelete = new Button();
            btnupdate = new Button();
            btnadd = new Button();
            label4 = new Label();
            listViewcategories = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Location = new Point(140, 128);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 29);
            btnback.TabIndex = 0;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboStatus);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtdes);
            groupBox1.Controls.Add(txtname);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 182);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Active", "Deactive" });
            cboStatus.Location = new Point(91, 133);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(188, 28);
            cboStatus.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 133);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Status";
            // 
            // txtdes
            // 
            txtdes.Location = new Point(88, 70);
            txtdes.Multiline = true;
            txtdes.Name = "txtdes";
            txtdes.Size = new Size(314, 57);
            txtdes.TabIndex = 3;
            // 
            // txtname
            // 
            txtname.Location = new Point(88, 37);
            txtname.Name = "txtname";
            txtname.Size = new Size(169, 27);
            txtname.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 34);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btndelete);
            groupBox2.Controls.Add(btnupdate);
            groupBox2.Controls.Add(btnback);
            groupBox2.Controls.Add(btnadd);
            groupBox2.Location = new Point(506, 77);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 167);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actions";
            // 
            // btndelete
            // 
            btndelete.Location = new Point(19, 128);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(94, 29);
            btndelete.TabIndex = 2;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Location = new Point(19, 80);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(94, 32);
            btnupdate.TabIndex = 1;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(19, 27);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 35);
            btnadd.TabIndex = 0;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(274, 15);
            label4.Name = "label4";
            label4.Size = new Size(168, 41);
            label4.TabIndex = 3;
            label4.Text = "Categories";
            // 
            // listViewcategories
            // 
            listViewcategories.Location = new Point(40, 291);
            listViewcategories.Name = "listViewcategories";
            listViewcategories.Size = new Size(716, 121);
            listViewcategories.TabIndex = 4;
            listViewcategories.UseCompatibleStateImageBehavior = false;
            // 
            // categoriesform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewcategories);
            Controls.Add(label4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "categoriesform";
            Text = "categoriesform";
            Load += categoriesform_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private GroupBox groupBox1;
        private TextBox txtdes;
        private TextBox txtname;
        private Label label2;
        private Label label1;
        private ComboBox cboStatus;
        private Label label3;
        private GroupBox groupBox2;
        private Button btndelete;
        private Button btnupdate;
        private Button btnadd;
        private Label label4;
        private ListView listViewcategories;
    }
}
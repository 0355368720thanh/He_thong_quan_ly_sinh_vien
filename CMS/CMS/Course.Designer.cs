namespace CMS
{
    partial class Course
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btnBack = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            cboAss = new ComboBox();
            btnSave = new Button();
            btnSub = new Button();
            txtFilePath = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-13, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 63);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 41);
            label1.TabIndex = 0;
            label1.Text = "Programming";
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(btnBack);
            panel2.Location = new Point(0, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(769, 75);
            panel2.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaptionText;
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(555, 24);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(21, 59);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 2;
            label2.Text = "Assigment1FirstChance";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboAss);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(btnSub);
            groupBox1.Controls.Add(txtFilePath);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(32, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(643, 218);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Assignment1_Programming";
            // 
            // cboAss
            // 
            cboAss.FormattingEnabled = true;
            cboAss.Location = new Point(206, 94);
            cboAss.Name = "cboAss";
            cboAss.Size = new Size(215, 28);
            cboAss.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.OrangeRed;
            btnSave.ForeColor = SystemColors.Control;
            btnSave.Location = new Point(205, 141);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(216, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.OrangeRed;
            btnSub.ForeColor = SystemColors.Control;
            btnSub.Location = new Point(445, 52);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(86, 29);
            btnSub.TabIndex = 4;
            btnSub.Text = "Browrse";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Enabled = false;
            txtFilePath.Location = new Point(206, 52);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(215, 27);
            txtFilePath.TabIndex = 3;
            txtFilePath.TextChanged += txtFilePath_TextChanged;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(713, 426);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Course";
            Text = "Course";
            Load += Course_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnSub;
        private TextBox txtFilePath;
        private Button btnSave;
        private Button btnBack;
        private ComboBox cboAss;
    }
}
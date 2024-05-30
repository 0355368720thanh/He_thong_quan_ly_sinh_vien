namespace LibaryOnline
{
    partial class HomeForm
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
            label1 = new Label();
            btnCategories = new Button();
            btnBook = new Button();
            btnAuthor = new Button();
            btnPublisher = new Button();
            btnLogout = new Button();
            label2 = new Label();
            labuser = new Label();
            labusername = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(431, 46);
            label1.TabIndex = 0;
            label1.Text = "He thong quan ly thu vien";
            // 
            // btnCategories
            // 
            btnCategories.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCategories.Location = new Point(38, 105);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(151, 88);
            btnCategories.TabIndex = 1;
            btnCategories.Text = "Quan ly danh muc sach";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnBook
            // 
            btnBook.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBook.Location = new Point(234, 105);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(144, 88);
            btnBook.TabIndex = 2;
            btnBook.Text = "Quan Ly Sach";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // btnAuthor
            // 
            btnAuthor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAuthor.Location = new Point(427, 105);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(149, 88);
            btnAuthor.TabIndex = 3;
            btnAuthor.Text = "Quan Ly Tac Gia";
            btnAuthor.UseVisualStyleBackColor = true;
            // 
            // btnPublisher
            // 
            btnPublisher.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPublisher.Location = new Point(617, 108);
            btnPublisher.Name = "btnPublisher";
            btnPublisher.Size = new Size(136, 85);
            btnPublisher.TabIndex = 4;
            btnPublisher.Text = "Quan ly nha xuat ban";
            btnPublisher.UseVisualStyleBackColor = true;
            btnPublisher.Click += btnPulisher_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(34, 398);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(118, 29);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Thoat";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 39);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 6;
            label2.Text = "Hi";
            // 
            // labuser
            // 
            labuser.AutoSize = true;
            labuser.Location = new Point(599, 41);
            labuser.Name = "labuser";
            labuser.Size = new Size(0, 20);
            labuser.TabIndex = 7;
            // 
            // labusername
            // 
            labusername.AutoSize = true;
            labusername.Location = new Point(599, 39);
            labusername.Name = "labusername";
            labusername.Size = new Size(41, 20);
            labusername.TabIndex = 8;
            labusername.Text = "aaaa";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labusername);
            Controls.Add(labuser);
            Controls.Add(label2);
            Controls.Add(btnLogout);
            Controls.Add(btnPublisher);
            Controls.Add(btnAuthor);
            Controls.Add(btnBook);
            Controls.Add(btnCategories);
            Controls.Add(label1);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCategories;
        private Button btnBook;
        private Button btnAuthor;
        private Button btnPublisher;
        private Button btnLogout;
        private Label label2;
        private Label labuser;
        private Label labusername;
    }
}
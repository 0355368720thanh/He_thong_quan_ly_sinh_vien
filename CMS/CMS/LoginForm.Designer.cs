namespace CMS
{
    partial class LoginForm
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
            panel2 = new Panel();
            label5 = new Label();
            btnExit = new Button();
            btnLogin = new Button();
            label4 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Location = new Point(-13, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 72);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(label5);
            panel2.Location = new Point(197, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(616, 132);
            panel2.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(68, 26);
            label5.Name = "label5";
            label5.Size = new Size(441, 81);
            label5.TabIndex = 0;
            label5.Text = "CMS BTEC FPT";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.OrangeRed;
            btnExit.ForeColor = SystemColors.Control;
            btnExit.Location = new Point(406, 325);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(107, 41);
            btnExit.TabIndex = 20;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(225, 325);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 41);
            btnLogin.TabIndex = 19;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(146, 258);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 18;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(146, 197);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 17;
            label3.Text = "UserName";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(274, 262);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(239, 27);
            txtPassword.TabIndex = 16;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(274, 201);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(239, 27);
            txtUserName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(335, 144);
            label2.Name = "label2";
            label2.Size = new Size(92, 41);
            label2.TabIndex = 14;
            label2.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources._403636691_245176878341477_3444820913802593133_n2;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(775, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Name = "LoginForm";
            Text = "LoginForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Button btnExit;
        private Button btnLogin;
        private Label label4;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label2;
    }
}
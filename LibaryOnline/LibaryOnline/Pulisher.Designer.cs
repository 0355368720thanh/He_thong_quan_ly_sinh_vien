namespace LibaryOnline
{
    partial class Pulisher
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
            btbak = new Button();
            groupBox1 = new GroupBox();
            txtWeb = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            listViewPulisher = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(317, 26);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 0;
            label1.Text = "Publisher";
            // 
            // btbak
            // 
            btbak.Location = new Point(150, 159);
            btbak.Name = "btbak";
            btbak.Size = new Size(94, 29);
            btbak.TabIndex = 1;
            btbak.Text = "back";
            btbak.UseVisualStyleBackColor = true;
            btbak.Click += btbak_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtWeb);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(44, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 274);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information";
            // 
            // txtWeb
            // 
            txtWeb.Location = new Point(114, 218);
            txtWeb.Name = "txtWeb";
            txtWeb.Size = new Size(329, 27);
            txtWeb.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(158, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(114, 124);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(189, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(114, 77);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(329, 27);
            txtAddress.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(114, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(158, 27);
            txtName.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 221);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 4;
            label6.Text = "Web";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 174);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 124);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 77);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 1;
            label3.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 36);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btbak);
            groupBox2.Location = new Point(520, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 204);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Actions";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(26, 126);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(26, 77);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(26, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // listViewPulisher
            // 
            listViewPulisher.Location = new Point(89, 402);
            listViewPulisher.Name = "listViewPulisher";
            listViewPulisher.Size = new Size(618, 156);
            listViewPulisher.TabIndex = 4;
            listViewPulisher.UseCompatibleStateImageBehavior = false;
            // 
            // Pulisher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 615);
            Controls.Add(listViewPulisher);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Pulisher";
            Text = "Form2";
            Load += Pulisher_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btbak;
        private GroupBox groupBox1;
        private TextBox txtWeb;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ListView listViewPulisher;
    }
}
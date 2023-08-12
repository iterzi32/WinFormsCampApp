namespace WinFormsCampApp.Forms
{
    partial class RegisterForm
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
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            btnRegister = new Button();
            txtPassword = new TextBox();
            label4 = new Label();
            txtFullName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(195, 42);
            label1.Name = "label1";
            label1.Size = new Size(285, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Kayıt Formu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 150);
            label2.Name = "label2";
            label2.Size = new Size(190, 24);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(121, 197);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 1;
            label3.Text = "Şifre :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(220, 150);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(238, 32);
            txtUserName.TabIndex = 2;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Black;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(221, 265);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(238, 40);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(220, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(237, 32);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(85, 103);
            label4.Name = "label4";
            label4.Size = new Size(130, 24);
            label4.TabIndex = 1;
            label4.Text = "Ad Soyad :";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(220, 103);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(238, 32);
            txtFullName.TabIndex = 1;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(628, 352);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(txtFullName);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private Button btnRegister;
        private TextBox txtPassword;
        private Label label4;
        private TextBox txtFullName;
    }
}
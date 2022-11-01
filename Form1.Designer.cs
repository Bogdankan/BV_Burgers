namespace BV_Burgers
{
    partial class loginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.logIn = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passField = new System.Windows.Forms.TextBox();
            this.continueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.Label();
            this.needLogin = new System.Windows.Forms.Label();
            this.needPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 499);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Arial Narrow", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.Red;
            this.closeButton.Location = new System.Drawing.Point(707, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 44);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "×";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // logIn
            // 
            this.logIn.AutoSize = true;
            this.logIn.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logIn.Location = new System.Drawing.Point(407, 105);
            this.logIn.Name = "logIn";
            this.logIn.Size = new System.Drawing.Size(97, 35);
            this.logIn.TabIndex = 2;
            this.logIn.Text = "Log In";
            // 
            // loginField
            // 
            this.loginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginField.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(413, 187);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(300, 26);
            this.loginField.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(19)))), ((int)(((byte)(238)))));
            this.panel1.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(413, 227);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 2);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(19)))), ((int)(((byte)(238)))));
            this.panel2.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(413, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 2);
            this.panel2.TabIndex = 6;
            // 
            // passField
            // 
            this.passField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passField.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(413, 265);
            this.passField.Name = "passField";
            this.passField.PasswordChar = '•';
            this.passField.Size = new System.Drawing.Size(300, 26);
            this.passField.TabIndex = 5;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(138)))), ((int)(((byte)(19)))));
            this.continueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueButton.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.Color.White;
            this.continueButton.Location = new System.Drawing.Point(413, 331);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(300, 34);
            this.continueButton.TabIndex = 7;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(410, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(410, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter password";
            // 
            // signUp
            // 
            this.signUp.AutoSize = true;
            this.signUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.signUp.Location = new System.Drawing.Point(477, 397);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(177, 17);
            this.signUp.TabIndex = 10;
            this.signUp.Text = "Have no account? Sign Up";
            this.signUp.Click += new System.EventHandler(this.regist_Click);
            // 
            // needLogin
            // 
            this.needLogin.AutoSize = true;
            this.needLogin.ForeColor = System.Drawing.Color.Red;
            this.needLogin.Location = new System.Drawing.Point(555, 152);
            this.needLogin.Name = "needLogin";
            this.needLogin.Size = new System.Drawing.Size(142, 17);
            this.needLogin.TabIndex = 26;
            this.needLogin.Text = "*обязательное поле";
            this.needLogin.Visible = false;
            // 
            // needPassword
            // 
            this.needPassword.AutoSize = true;
            this.needPassword.ForeColor = System.Drawing.Color.Red;
            this.needPassword.Location = new System.Drawing.Point(555, 232);
            this.needPassword.Name = "needPassword";
            this.needPassword.Size = new System.Drawing.Size(142, 17);
            this.needPassword.TabIndex = 27;
            this.needPassword.Text = "*обязательное поле";
            this.needPassword.Visible = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 499);
            this.Controls.Add(this.needPassword);
            this.Controls.Add(this.needLogin);
            this.Controls.Add(this.signUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.logIn);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label logIn;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label signUp;
        private System.Windows.Forms.Label needLogin;
        private System.Windows.Forms.Label needPassword;
    }
}


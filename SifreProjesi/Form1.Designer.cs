
namespace SifreProjesi
{
    partial class Form1
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
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnForgotPassword = new System.Windows.Forms.Button();
            this.tbxDogrula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDogrula = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbxNewPassword = new System.Windows.Forms.TextBox();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(28, 68);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(152, 22);
            this.tbxMail.TabIndex = 0;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(28, 151);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(152, 22);
            this.tbxPassword.TabIndex = 1;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(53, 245);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 35);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.Location = new System.Drawing.Point(28, 194);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Size = new System.Drawing.Size(131, 35);
            this.btnForgotPassword.TabIndex = 3;
            this.btnForgotPassword.Text = "Forgot Password";
            this.btnForgotPassword.UseVisualStyleBackColor = true;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // tbxDogrula
            // 
            this.tbxDogrula.Location = new System.Drawing.Point(28, 327);
            this.tbxDogrula.Name = "tbxDogrula";
            this.tbxDogrula.Size = new System.Drawing.Size(152, 22);
            this.tbxDogrula.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mail Adresiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifreniz :";
            // 
            // lblDogrula
            // 
            this.lblDogrula.AutoSize = true;
            this.lblDogrula.Location = new System.Drawing.Point(25, 296);
            this.lblDogrula.Name = "lblDogrula";
            this.lblDogrula.Size = new System.Drawing.Size(93, 17);
            this.lblDogrula.TabIndex = 7;
            this.lblDogrula.Text = "Kodu Giriniz :";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(25, 366);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(99, 17);
            this.lblNewPassword.TabIndex = 9;
            this.lblNewPassword.Text = "Yeni Şifreniz : ";
            // 
            // tbxNewPassword
            // 
            this.tbxNewPassword.Location = new System.Drawing.Point(28, 397);
            this.tbxNewPassword.Name = "tbxNewPassword";
            this.tbxNewPassword.Size = new System.Drawing.Size(152, 22);
            this.tbxNewPassword.TabIndex = 8;
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.Location = new System.Drawing.Point(66, 425);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(75, 35);
            this.btnNewPassword.TabIndex = 10;
            this.btnNewPassword.Text = "Yenile";
            this.btnNewPassword.UseVisualStyleBackColor = true;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 484);
            this.Controls.Add(this.btnNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbxNewPassword);
            this.Controls.Add(this.lblDogrula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxDogrula);
            this.Controls.Add(this.btnForgotPassword);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxMail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.TextBox tbxDogrula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDogrula;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbxNewPassword;
        private System.Windows.Forms.Button btnNewPassword;
    }
}


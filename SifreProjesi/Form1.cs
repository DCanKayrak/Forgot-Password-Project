﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SifreProjesi
{
    public partial class Form1 : Form
    {

        public const string MAIL = "xxx"; // kendi mail hesabınızı giriniz.Mail bu hesap üzerinden gönderilecektir.
        public const string SIFRE = "yyy"; // kendi mail şifreniz
        private int mailSifresi; // random oluşturulacak olan şifremiz.

        AccountDal ac = new AccountDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // şifre yenileme kısımlarını gizliyoruz.
            tbxDogrula.Visible = false;
            lblDogrula.Visible = false;
            lblNewPassword.Visible = false;
            tbxNewPassword.Visible = false;
            btnNewPassword.Visible = false;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // LogIn kısmı
            if (ac.LogIn(new Account { Mail = tbxMail.Text,Password=tbxPassword.Text}))
            {
                MessageBox.Show("Giriş Yapıldı!");
            }
            else
            {
                MessageBox.Show("Mail veya parola yanlış");
            }
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            // şifremi unuttum.Böyle bir hesap bulunuyor mu ?
            if (ac.isAccountExists(tbxMail.Text))
            {
                Random ran = new Random();
                mailSifresi = ran.Next(1000, 9999);

                MailMessage msj = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential(MAIL, SIFRE);
                istemci.Port = 587;
                istemci.Host = "smtp-mail.outlook.com"; // outlook ile bu göndermek için kodumuz budur.
                // gmail ile istenirse smtp.gmail.com ile sağlanabilir.
                // bunun için google hesabınızın düşük güvenlik modunun açılması lazımdır!
                istemci.EnableSsl = true;
                msj.To.Add(tbxMail.Text);
                msj.From = new MailAddress(MAIL);
                msj.Subject = "Şifre Yenileme";
                msj.Body = "Şifre Yenilemek için kodunuz : " + mailSifresi.ToString();

                istemci.Send(msj);
                tbxDogrula.Visible = true;
                lblDogrula.Visible = true;
                lblNewPassword.Visible = true;
                tbxNewPassword.Visible = true;
                btnNewPassword.Visible = true;
            }
            else
            {
                MessageBox.Show("Girdiğiniz Mail'e ait bir hesap bulunmamakta!");
            }
            
        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
         // yeni şifre oluşturma kısmı   
            if(tbxNewPassword.Text.Length != 0 && mailSifresi.ToString() == tbxDogrula.Text)
            {
                MessageBox.Show("Şifreniz Değiştirildi.");
                var acc = ac.GetAccount(tbxMail.Text);
                ac.Update(new Account { Id = acc.Id, Mail = acc.Mail,Password = tbxNewPassword.Text});
            }
            else
            {
                MessageBox.Show("Girilen Kod Yanlış Veya Yeni şifre çok kısa.");
            }
        }
    }
}

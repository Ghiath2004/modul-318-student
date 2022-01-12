using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace SBB_Klon
{
    public partial class emailSenden : Form
    {
        public emailSenden(string details)
        {
            InitializeComponent();
            txtEmailBody.Text = details;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                string toMail = txtEmailTo.Text;
                string subject = txtEmailSubject.Text;
                string body = txtEmailBody.Text;

                MailMessage email = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587);

                email.From = new MailAddress("mysbbklonapp.ghiath@gmail.com");
                email.To.Add(toMail);
                email.Subject = subject;
                email.Body = body;

                SmtpServer.Credentials = new System.Net.NetworkCredential("mysbbklonapp.ghiath@gmail.com", "mysbbklon2022");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(email);
                MessageBox.Show("Mail gesendet");

                txtEmailTo.Text = "";
                txtEmailSubject.Text = "";
                txtEmailBody.Text = "";

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler:\n" + ex.ToString());
            }
        }

        private void txtVerbindungenStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtEmailTo.Text != "" && txtEmailSubject.Text != "" && txtEmailBody.Text != "")
            {
                btnSendEmail.Enabled = true;
            }
            else
            {
                btnSendEmail.Enabled = false;
            }
        }
    }
}

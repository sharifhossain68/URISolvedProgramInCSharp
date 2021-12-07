 protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mailMessage = new MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtMessage.Text);
                mailMessage.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("aabduallahsharif@gmail.com", "as01534718068");
                client.Send(mailMessage);
                lblStatus.Text = "Mail send successfully";

                txtTo.Text = "";
                txtFrom.Text = "";
                txtSubject.Text = "";
                txtMessage.Text = "";
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }
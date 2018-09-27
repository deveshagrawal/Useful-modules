public SendMail()
{
  string FromAddress = "myaddress@gmail.com";
  string FromAdressTitle = "Email Title";
  string ToAddress = "someaddress@domain.com";
  string ToAdressTitle = "To address Title";
  string Subject = "RE: some subject line";

  //Smtp Server
  string SmtpServer = "smtp.gmail.com";
  //Smtp Port Number
  int SmtpPortNumber = 587;

  var mimeMessage = new MimeMessage();
  mimeMessage.From.Add(new MailboxAddress(FromAdressTitle, FromAddress));
  mimeMessage.To.Add(new MailboxAddress(ToAdressTitle, ToAddress));
  mimeMessage.Subject = Subject;

  var builder = new BodyBuilder();
  builder.Attachments.Add(@"filepath");
  mimeMessage.Body = builder.ToMessageBody();

  using (var client = new SmtpClient())
  {
    client.Connect(SmtpServer, SmtpPortNumber, false);
    client.Authenticate("username", "password");
    client.Send(mimeMessage);
    client.Disconnect(true);
  }
}

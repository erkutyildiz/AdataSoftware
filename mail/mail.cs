using System.Net.Mail;
using System.Text;



// Command line argument must the the SMTP host.
SmtpClient client = new SmtpClient();
client.Port = 587;
client.Host = "smtp.gmail.com";
client.EnableSsl = true;
client.Timeout = 10000;
client.DeliveryMethod = SmtpDeliveryMethod.Network;
client.UseDefaultCredentials = false;
client.Credentials = new System.Net.NetworkCredential("erkutyildizz3@gmail.com","2001980037");

MailMessage mm = new MailMessage("admin@adata.tech", "erkutyildiz@msn.com", "test", "test2");
mm.BodyEncoding = UTF8Encoding.UTF8;
mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

client.Send(mm);
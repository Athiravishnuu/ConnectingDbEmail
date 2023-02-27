using System.Net.Mail;

namespace ConnectingDbEmail.Helper
{
    public class Helperclass
    {
        public int GetOtp(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string GetEmail(string email,string Otp) 
        {
            try
            {
                Random random = new Random();
                int num = random.Next();
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("athira007p@gmail.com");
                mail.To.Add("vishnuramesh33222@gmail.com");
                mail.Priority = MailPriority.High;
                mail.Subject = "Test Email";
                Console.WriteLine("enter you mailid");
                Console.WriteLine();
                mail.Body = num.ToString();
                SmtpServer.Port = 587;
                Console.WriteLine($"your otp is generated check you mail");
                Console.ReadKey();
                SmtpServer.Credentials = new System.Net.NetworkCredential("athira007p@gmail.com", "cuvemprujgfntbox");
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine("Email Send Succesfully");

            return "";
        }

    }
}

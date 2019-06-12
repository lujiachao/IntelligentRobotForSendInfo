using System;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace SendQQEMail
{
    class Program
    {
        public static void Main(string[] args)
        {
            MailMessage mailMsg = new MailMessage();
            mailMsg.From = new MailAddress("*********@qq.com", "陆佳超");
            mailMsg.To.Add(new MailAddress("*********@qq.com"));
            mailMsg.Subject = "邮件发送测试";
            var sb = new StringBuilder();
            sb.Append("测试测试测试测试");
            sb.Append("嘿嘿");
            mailMsg.Body = sb.ToString();
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.qq.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("*******@qq.com","***********");
            try
            {
                client.Send(mailMsg);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("邮件已发送，请注意查收！");
            Console.ReadKey();
        }
    }
}

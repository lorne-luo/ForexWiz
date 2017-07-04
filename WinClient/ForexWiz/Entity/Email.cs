using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace LeoStudio.ForexWiz.Entity
{
    class Email
    {
        public static string SendFrom = "leandro@foxmail.com";
        public static string UserName = "leandro@foxmail.com";
        public static string SmtpHost = "smtp.qq.com";
        public static int Port = 25;
        public static string Password = "jp7wutaZVbg=";
        public static string GetPassword()
        {
            return new DES_().Decrypt(Password);
        }

        public static void SendMail(string sendTo, string subject, string content)
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            // instantiate message object System.Net.Mail. 
            MailAddress address = new System.Net.Mail.MailAddress(Email.SendFrom, subject);
            msg.From = address;
            msg.To.Add(sendTo);
            msg.Subject = subject;
            msg.Body = content;
            System.Net.Mail.SmtpClient sc = new System.Net.Mail.SmtpClient();
            // instantiate smtp object sc.Host = "my_SMTP_address";   
            // your smtp host 
            sc.Host = Email.SmtpHost;
            sc.EnableSsl = false;
            sc.Port = Email.Port;  //发送邮件服务器：smtp.qq.com，使用SSL，端口号465或587
            System.Net.NetworkCredential nc = new System.Net.NetworkCredential();
            // your network credentials object 
            nc.UserName = Email.UserName;
            nc.Password = Email.GetPassword();
            sc.Credentials = nc;     // pass network credentials to smtp 
            sc.Timeout = 30000;
            sc.Send(msg);  // paas message to smtp  and send and email.
        }
    }
}

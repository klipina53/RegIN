using System.Net;
using System.Net.Mail;

namespace RegIN_Lipina.Classes
{
    public class SendMail
    {

        public static void SendMessage(string Message, string To)
        {

            var smtpClient = new SmtpClient("smtp.yandex.ru")
            {

                Port = 587,

                Credentials = new NetworkCredential("L9504609974l@yandex.ru", "xmzwxiclmxivlpjw"),

                EnableSsl = true,
            };

            smtpClient.Send("L9504609974l@yandex.ru", To, "Проект lipina325", Message);
        }
    }
}
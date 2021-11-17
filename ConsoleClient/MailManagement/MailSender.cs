using System;

namespace ConsoleClient
{
    class MailSender : IMailSender
    {
        public void Send()
        {
            Console.WriteLine("Email wird an xyz versendet (x mal)");
        }
    }
}
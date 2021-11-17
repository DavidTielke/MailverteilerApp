using System;

namespace ConsoleClient
{
    class MailDownlaoder : IMailDownlaoder
    {
        public void DownloadMail()
        {
            Console.WriteLine("Email wurde heruntergeladen");
        }
    }
}
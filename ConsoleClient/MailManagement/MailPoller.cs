using System;

namespace ConsoleClient
{
    class MailPoller : IMailPoller
    {
        private readonly IMailDownlaoder _downlaoder;

        public MailPoller(IMailDownlaoder downlaoder)
        {
            _downlaoder = downlaoder;
        }

        public event Action NewMail;

        public void Stop()
        {
            Console.WriteLine("Polling gestoppt");
        }

        public void NewMailDetected()
        {
            Console.WriteLine("Neue Email erkannt");
        }

        public void Start()
        {
            Console.WriteLine("Polling gestartet");

            NewMailDetected();

            _downlaoder.DownloadMail();

            OnNewMail();
        }

        protected virtual void OnNewMail()
        {
            NewMail?.Invoke();
        }
    }
}
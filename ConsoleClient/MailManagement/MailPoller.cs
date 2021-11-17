using System;

namespace ConsoleClient
{
    class MailPoller : IMailPoller
    {
        private readonly IMessageDistributor _distributor;
        private readonly IMailDownlaoder _downlaoder;

        public MailPoller(IMessageDistributor distributor, IMailDownlaoder downlaoder)
        {
            _distributor = distributor;
            _downlaoder = downlaoder;
        }

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

            _distributor.Distribute();
        }
    }
}
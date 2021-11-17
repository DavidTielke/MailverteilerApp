using System;

namespace ConsoleClient
{
    class MessageDistributor : IMessageDistributor
    {
        private readonly IMailPoller _poller;
        private readonly IMailSender _sender;
        private readonly IReceiverManager _receivcerManager;

        public MessageDistributor(IMailPoller poller, IMailSender sender, IReceiverManager receivcerManager)
        {
            _poller = poller;
            _sender = sender;
            _receivcerManager = receivcerManager;
        }

        public void Stop()
        {
            Console.WriteLine("Mailverteiler gestoppt");
        }

        public void Distribute()
        {
            Console.WriteLine("Verteilung beginnt");

            _receivcerManager.Load();

            _sender.Send();

            Console.WriteLine("Verteilung abgeschlossen");
        }

        public void Start()
        {
            Console.WriteLine("Mailverteiler gestartet");
            _poller.Start();
        }
    }
}
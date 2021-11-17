namespace ConsoleClient
{
    // Namensmuster
    // Manager
    // Repository
    // Distributor
    // Poller
    // Downloader
    // Sender


    class Program
    {
        static void Main(string[] args)
        {
            var downloader = new MailDownlaoder();
            var poller = new MailPoller(null, downloader);
            var sender = new MailSender();
            var repo = new ReceiverRepository();
            var manager = new ReceiverManager(repo);

            var dist = new MessageDistributor(poller, sender, manager);

            dist.Start();
            dist.Stop();
        }
    }
}

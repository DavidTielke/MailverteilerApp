using Ninject;

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
            var kernel = new StandardKernel();

            kernel.Bind<IMessageDistributor>().To<MessageDistributor>();
            kernel.Bind<IMailDownlaoder>().To<MailDownlaoder>();
            kernel.Bind<IMailPoller>().To<MailPoller>();
            kernel.Bind<IMailSender>().To<MailSender>();
            kernel.Bind<IReceiverRepository>().To<ReceiverRepository>();
            kernel.Bind<IReceiverManager>().To<ReceiverManager>();

            var dist = kernel.Get<IMessageDistributor>();

            dist.Start();
            dist.Stop();
        }
    }
}

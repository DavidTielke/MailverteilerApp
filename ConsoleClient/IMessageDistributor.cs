namespace ConsoleClient
{
    internal interface IMessageDistributor
    {
        void Stop();
        void Distribute();
        void Start();
    }
}
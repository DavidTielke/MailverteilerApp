using System;

namespace ConsoleClient
{
    class ReceiverManager : IReceiverManager
    {
        private readonly IReceiverRepository _repository;

        public ReceiverManager(IReceiverRepository repository)
        {
            _repository = repository;
        }

        public void Load()
        {
            Console.WriteLine("Empfänger ermittelt");
            _repository.Query();
        }
    }
}
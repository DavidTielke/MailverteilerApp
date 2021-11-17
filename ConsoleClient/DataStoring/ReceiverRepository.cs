using System;

namespace ConsoleClient
{
    class ReceiverRepository : IReceiverRepository
    {
        public void Query()
        {
            Console.WriteLine("Empfänger aus Datenbank geladen");
        }
    }
}
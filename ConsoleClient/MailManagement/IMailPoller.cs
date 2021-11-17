using System;

namespace ConsoleClient
{
    internal interface IMailPoller
    {
        void Stop();
        void NewMailDetected();
        void Start();
        event Action NewMail;
    }
}
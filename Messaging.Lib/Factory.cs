using Messaging.Lib.Interfaces;

namespace Messaging.Lib
{
    public abstract class Factory
    {
        protected abstract IMessenger CreateMessenger();

        public IMessenger CreateMessengerApp()
        {
            var messenger = CreateMessenger();
            return messenger;
        }
    }
}

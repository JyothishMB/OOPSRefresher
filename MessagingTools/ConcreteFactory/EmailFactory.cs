using Messaging.Lib;
using Messaging.Lib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingTools.ConcreteFactory
{
    public class EmailFactory : Factory
    {
        protected override IMessenger CreateMessenger()
        {
            return new Email();
        }
    }
}

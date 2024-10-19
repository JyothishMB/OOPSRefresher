using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lib
{
    public interface ISubject
    {
        void Register(IObserver observer);
        void Remove(IObserver observer);
        void NotifyObserver();
    }
}

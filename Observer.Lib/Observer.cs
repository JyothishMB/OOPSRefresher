using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Lib
{
    public class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName)
        {
            UserName = userName;
        }

        public void Subscribe(ISubject subject)
        {
            subject.Register(this);
        }

        public void UnSubscribe(ISubject subject)
        {
            subject.Remove(this);
        }

        public void Update(bool isAvailable)
        {
            Console.WriteLine("Hello " + UserName + ", Report is ready now. Please check.");
        }
    }
}

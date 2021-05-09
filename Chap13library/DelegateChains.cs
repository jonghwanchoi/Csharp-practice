using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13library
{
    public delegate void Notify(string message);
    public class DelegateChains
    {
    }

    public class Notifier
    {
        public Notify EventOccured;
    }

    public class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappend : {message}");
        }
    }
}

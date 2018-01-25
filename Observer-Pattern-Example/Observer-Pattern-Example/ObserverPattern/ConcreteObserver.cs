using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Example.ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        public void Update(int state)
        {
            Console.WriteLine("Mein status ist : " + state);
        }
    }
}

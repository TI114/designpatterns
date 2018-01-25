using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Example
{
    public class client : ObserverPattern.ConcreteSubject
    {
        public void test()
        {
            ObserverPattern.ConcreteSubject SubjectA = new ObserverPattern.ConcreteSubject();
            SubjectA.attach(new ObserverPattern.ConcreteObserver());

            SubjectA.Setstate(2);
            // Ausgabe in der Console: "Mein Status ist : 2"
            SubjectA.Setstate(5);
            // Ausgabe in der Console: "Mein Status ist : 5"
        }
    }
}

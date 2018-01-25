using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Example.ObserverPattern
{
    public class ConcreteSubject : Subject
    {

        private int state = 0;

        public void Setstate(int value)
        {
            state = value;
        }


    }
}

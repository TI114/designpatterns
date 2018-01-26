using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Example.ObserverPattern
{
    public interface Observer
    {
        void Update(int state);
    }
}

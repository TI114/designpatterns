using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern_Example.ObserverPattern
{
    public abstract class Subject
    {
        List<Observer> observerList = new List<Observer>();

        // neuen Observer anmelden
        public void attach(Observer newObserver)
        {
            observerList.Add(newObserver);        
        }

        // Observer entfernen
        public void detach(Observer newObserver)
        {
            observerList.Remove(newObserver);
        }

        // Observer benachrichtigen
        protected void notifyObservers(int state)
        {
            // Alle Observer in der Liste abarbeiten
            foreach (Observer obs in observerList)
            {
                obs.Update(state);
            }

        }

    }
}

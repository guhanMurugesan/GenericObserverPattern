using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericObservation
{
    class DataProvider :IObservable<IDataConsume>
    {
        ObserverCollection _observers;
        public DataProvider()
        {
            _observers = new ObserverCollection();
        }

        public void Notify()
        {
            _observers.callback();
        }

        public void AddObserver(IDataConsume observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IDataConsume observer)
        {
            _observers.Add(observer);
        }
    }
}

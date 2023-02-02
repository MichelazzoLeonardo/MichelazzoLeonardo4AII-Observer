using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_airport
{
    class Unsubscriber<FlightInfo>:IDisposable
    {
        private List<IObserver<FlightInfo>> _observers;
        private IObserver<FlightInfo> _observer;

        internal Unsubscriber(List<IObserver<FlightInfo>> observers, IObserver<FlightInfo> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }
        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}

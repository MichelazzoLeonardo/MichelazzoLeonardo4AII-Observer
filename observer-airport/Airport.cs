using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_airport
{
    public class Airport:IObservable<FlightInfo>
    {
        private List<IObserver<FlightInfo>> _observers;
        private List<FlightInfo> _flights;

        public Airport()
        {
            _observers = new List<IObserver<FlightInfo>>();
            _flights = new List<FlightInfo>();
        }
        public IDisposable Subscribe(IObserver<FlightInfo> observer)
        {
            // Check whether observer is already registered. If not, add it
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                // Provide observer with existing data.
                foreach (var item in _flights)
                    observer.OnNext(item);
            }
            return new Unsubscriber<FlightInfo>(_observers, observer);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_airport
{
    public class Screen :IObserver<FlightInfo>
    {
    private IDisposable _cancellation;
    private List<FlightInfo> _flightInfos;

        public virtual void Subscribe(Airport provider)
        {
            _cancellation = provider.Subscribe(this);
        }
        public virtual void Unsubscribe()
        {
            _cancellation.Dispose();
            _flightInfos.Clear();
        }
        public virtual void OnCompleted()
        {
            _flightInfos.Clear();
        }
        // No implementation needed: Method is not called by the BaggageHandler class.
        public virtual void OnError(Exception e)
        {
            // No implementation.
        }
        public virtual void OnNext(FlightInfo info)
        {
            //shows next flight on screen
        }
    }
}

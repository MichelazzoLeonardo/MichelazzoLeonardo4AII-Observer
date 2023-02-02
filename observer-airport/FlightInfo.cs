using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_airport
{
    class FlightInfo
    {
        public int _n;
        public string _from;
        public string _to;
        public string _time;

        private string[] _locations = { "Italy", "France", "Ireland", "Spain", "Germany" };

        public FlightInfo()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            _n = r.Next(1000, 10000);
            do
            {
                _from = _locations[r.Next(0, 4)];
                _to = _locations[r.Next(0, 4)];
            } while (_from == _to);
            _time = TimeString(new string[] { $"{r.Next(0, 25)}", $"{r.Next(0, 60)}" });
        }
        public string TimeString(string[] t)
        {
            string TIME = "";
            
            if (t[0].Length == 1)
                TIME += "0" + t[0];
            else TIME += t[0];

            TIME += ":";

            if (t[1].Length == 1)
                TIME += "0" + t[1];
            else TIME += t[1];

            return TIME;
        }
        public override string ToString()
        {
            string r = $"flight number: {this._n}\nfrom: {this._from}\nto: {this._to}\ntime: {this._time}";
            return r;
        }
    }
}

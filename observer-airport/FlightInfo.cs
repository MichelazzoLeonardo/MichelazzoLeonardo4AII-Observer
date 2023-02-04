using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_airport
{
    public class FlightInfo
    {
        public string _time;
        public string _from;
        public string _to;
        public string _n;
        public string _gate;

        private string[] _locations = { "Italy", "France", "Ireland", "Spain", "Germany" };

        public FlightInfo()
        {
            Random r = new Random(DateTime.Now.Millisecond);

            _time = TimeString(new string[] { $"{r.Next(0, 24)}", $"{r.Next(0, 60)}" });
            do
            {
                _from = _locations[r.Next(0, 4)];
                _to = _locations[r.Next(0, 4)];
            } while (_from == _to);
            _n = r.Next(1000, 10000).ToString();
            _gate = r.Next(1, 13).ToString();
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
    }
}

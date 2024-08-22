using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sssChartVirsion
{
    public enum EventType
    {
        None,
        Arr,
        Load,
        Unload,
        End
    }
    internal class Event
    {
        public EventType type { get; set; }
        public string name { get; set; }
        public double time { get; set; }

        public double interArrTime;

        public Event(EventType type, string name, double time)
        {
            this.type = type;
            this.name = name;
            this.time = time;
        }
    }
}

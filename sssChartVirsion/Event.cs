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
        Unload
    }
    internal class Event
    {
        public EventType type = EventType.None;
        public readonly string name;

        public double time;
        public double interArrTime;

        public Event(EventType type, string name, double time)
        {
            this.type = type;
            this.name = name;
            this.time = time;
        }
    }
}

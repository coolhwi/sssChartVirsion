using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sssChartVirsion
{
    internal class EventCalender
    {
        public List<Event> events = new List<Event>();

        public void InputEvent(Event inputEvent)
        {
            events.Add(inputEvent);
            RefreshEvent();
        }
        public void RefreshEvent()
        {
            // 오름차순 정렬
            events.Sort((x1, x2) => x1.time.CompareTo(x2.time));
        }
        public void RemoveEvent()
        {
            events.RemoveAt(0);
        }

        public Event SelectEvent()
        {
            Event selectEvent = events[0];
            RemoveEvent();
            return selectEvent;
        }



    }
}

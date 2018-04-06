using NorwichCQRS.Infrastructure.EventMessaging;
using System;

namespace NorwichCQRS.Core.EventMessaging
{
    public class EventBase : IEvent
    {               
        public DateTime DateTime { get; set; }       
 
        public EventBase(DateTime dateTime)
        {
            if (dateTime != default(DateTime))
            {
                this.DateTime = dateTime;
            }
        }
    }
}

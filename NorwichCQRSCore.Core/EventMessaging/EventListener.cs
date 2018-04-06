using NorwichCQRS.Infrastructure;
using NorwichCQRS.Infrastructure.EventMessaging;

namespace NorwichCQRS.Core.EventMessaging
{
    public class EventListener : IListener
    {
        protected IEventHandlerFactory EventHandlerFactory { get; set; }

        public bool IsListening { get; protected set; }

        public EventListener(IEventHandlerFactory eventHandlerFactory)
        {
            EventHandlerFactory = eventHandlerFactory;
        }

        public virtual void Start() { this.IsListening = true; }

        public virtual void Stop() { this.IsListening = false; }
    }
}

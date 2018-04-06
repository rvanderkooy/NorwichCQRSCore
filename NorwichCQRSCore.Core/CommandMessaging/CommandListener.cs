using NorwichCQRS.Infrastructure;
using NorwichCQRS.Infrastructure.CommandMessaging;

namespace NorwichCQRS.Core.CommandMessaging
{
    public class CommandListener : IListener
    {
        protected ICommandHandlerFactory CommandHandlerFactory { get; set; }

        public bool IsListening { get; protected set; }

        public CommandListener(ICommandHandlerFactory commandHandlerFactory)
        {
            CommandHandlerFactory = commandHandlerFactory;
        }

        public virtual void Start() { this.IsListening = true; }

        public virtual void Stop() { this.IsListening = false; }
    }
}

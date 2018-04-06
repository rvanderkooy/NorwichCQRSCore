namespace NorwichCQRS.Infrastructure.CommandMessaging
{
    public interface ICommandBus
    {        
        void Send<TCommand>(TCommand command);
    }
}

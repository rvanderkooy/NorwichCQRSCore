namespace NorwichCQRS.Infrastructure.CommandMessaging
{
    public interface ICommandHandler<TCommand>
    {
        void Process(TCommand command);
    }
}

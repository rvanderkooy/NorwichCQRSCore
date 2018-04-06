namespace NorwichCQRS.Infrastructure.CommandMessaging
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<TCommand> GetHandler<TCommand>();

        void RegisterHandlerType<TCommand, TCommandHandler>()
            where TCommand : ICommand
            where TCommandHandler : ICommandHandler<TCommand>;
    }
}

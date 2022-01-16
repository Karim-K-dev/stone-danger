namespace Core.Commands.Handlers
{
    public interface ICommandHandler
    {
        void OnCommand(ICommand command);
    }
}
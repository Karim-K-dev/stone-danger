namespace Core.Commands.Handlers
{
    public struct EmptyCommandHandler : ICommandHandler
    {
        public void OnCommand(ICommand command)
        {
        }
    }
}
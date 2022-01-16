using Core.Commands.Handlers;

namespace Core.Commands.Extensions
{
    public static class ObjectExt
    {
        public static ICommandHandler GetCommandHandler(this object obj)
        {
            if (obj is ICommandHandler commandHandler)
            {
                return commandHandler;
            }

            return new EmptyCommandHandler();
        }

        public static ICommandHandler GetCommandHandler(this object obj, ICommand command)
        {
            if (obj is ICommandHandler commandHandler)
            {
                return commandHandler;
            }

            return new EmptyCommandHandler();
        }
    }
}
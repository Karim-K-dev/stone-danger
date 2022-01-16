using Core.Commands.Extensions;
using System;

namespace Core.Commands.Handlers
{
    [Serializable]
    public class SendToEntityHandler : ICommandHandler
    {
        private IEntity _entity;

        public void Construct(IEntity entity)
        {
            _entity = entity;
        }

        public void OnCommand(ICommand command)
        {
            var commandHandler = _entity.GetCommandHandler(command);
            commandHandler.OnCommand(command);
        }
    }
}
using Core.Commands.Extensions;
using Core.Components;
using System;
using UnityEngine;

namespace Core.Commands.Handlers
{
    [Serializable]
    public class ComponentsHandler : ICommandHandler
    {
        [SerializeReference]
        private IComponentCollection _components;

        public void Construct(IComponentCollection components)
        {
            _components = components;
        }

        public void OnCommand(ICommand command)
        {
            var commandHandler = _components.GetCommandHandler(command);
            commandHandler.OnCommand(command);
        }
    }
}
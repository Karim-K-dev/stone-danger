using System;
using Core.Components;
using Core.Commands.Handlers;
using Core.Commands;
using UnityEngine;

namespace Core
{
    [Serializable]
    public class Entity : IEntity, ICommandHandler
    {
        [SerializeReference]
        [SerializeReferenceButton]
        private IComponentCollection _components = new ComponentCollection();

        [SerializeReference]
        [SerializeReferenceButton]
        private ICommandHandler _commandHandler;

        public IComponentCollection Components => _components;

        public void OnCommand(ICommand command) => _commandHandler.OnCommand(command);

        public void Construct()
        {
            var commandHandler = new ComponentsHandler();
            commandHandler.Construct(_components);
            _commandHandler = commandHandler;
        }
    }
}
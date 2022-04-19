using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core.Commands;
using Core.Commands.Extensions;
using Core.Commands.Handlers;
using UnityEngine;
using Zenject;

namespace Core.Components
{
    [Serializable]
    public class ComponentCollection : IComponentCollection, ICommandHandler
    {
        [SerializeReference]
        [SerializeReferenceButton]
        private List<IComponent> _components = new List<IComponent>();

        public IEnumerable<T> Get<T>() => _components.OfType<T>();

        public int Count => _components.Count;

        public IEnumerator<IComponent> GetEnumerator() => _components.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _components.GetEnumerator();

        [Inject]
        private void Construct(DiContainer container)
        {
            foreach (var component in _components)
            {
                container.Inject(component);
            }
        }

        public void OnCommand(ICommand command)
        {
            foreach (var component in _components)
            {
                var commandHandler = component.GetCommandHandler(command);
                commandHandler.OnCommand(command);

            }
        }
    }
}
using System;
using Core.Commands;
using Core.Commands.Handlers;
using Core.Components;
using DamageSystem.Commands;
using UnityEngine;

namespace Components
{
    [Serializable]
    public class Health : IComponent, ICommandHandler
    {
        [SerializeReference]
        private float _value;

        public Type CommandType => typeof(DamageCommand);

        public void OnCommand(DamageCommand command)
        {
            _value -= command.Value;
        }

        public void OnCommand(ICommand command)
        {
            if (command is DamageCommand damageCommand)
            {
                OnCommand(damageCommand);
            }
        }
    }
}
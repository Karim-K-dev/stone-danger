using Core;
using Core.Commands.Extensions;
using Core.Commands.Handlers;
using DamageSystem.Commands;
using UnityEngine;

namespace DamageSystem.Behaviours
{
    public class DamageBehaviour : MonoBehaviour
    {
        public void DealDamage(IAvatar avatar)
        {
            var commandHandler = avatar.GetCommandHandler();
            DealDamage(commandHandler);
        }

        public void DealDamage(ICommandHandler commandHandler)
        {
            var command = new DamageCommand(10f);
            commandHandler?.OnCommand(command);
        }
    }
}
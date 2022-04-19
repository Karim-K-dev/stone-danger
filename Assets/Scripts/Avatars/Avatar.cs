using Core.Commands.Handlers;
using UnityEngine;
using Core.Commands;
using Core;
using Zenject;

public class Avatar : MonoBehaviour, IAvatar, ICommandHandler, IValidatable
{
    [SerializeReference]
    [SerializeReferenceButton]
    private IEntity _entity;

    [SerializeReference]
    [SerializeReferenceButton]
    private ICommandHandler _commandHandler;

    [Inject]
    public void Construct(DiContainer container)
    {
        container.Inject(_entity);
        container.Inject(_commandHandler);
    }

    private void OnValidate()
    {
        _entity ??= new Entity();
        _commandHandler ??= new SendToEntityHandler();
    }

    public void Validate()
    {
        var t = 10;
    }

    public void OnCommand(ICommand command)
    {
        _commandHandler.OnCommand(command);
    }
}
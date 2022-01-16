using Core.Commands.Handlers;
using UnityEngine;
using Core.Commands;
using Core;

public class Avatar : MonoBehaviour, IAvatar, ICommandHandler
{
    [SerializeReference]
    [SerializeReferenceButton]
    private IEntity _entity = new Entity();

    [SerializeReference]
    [SerializeReferenceButton]
    private ICommandHandler _commandHandler;

    private void Awake()
    {
        if (_entity is Entity simpleEntity)
        {
            simpleEntity.Construct();
        }

        if (_commandHandler is SendToEntityHandler sendToEntityHandler)
        {
            sendToEntityHandler.Construct(_entity);
        }
    }

    private void OnValidate()
    {
        if (!(_entity is Entity))
        {
            _entity = new Entity();
        }

        if (!(_commandHandler is SendToEntityHandler))
        {
            _commandHandler = new SendToEntityHandler();
        }
    }

    public void OnCommand(ICommand command)
    {
        _commandHandler.OnCommand(command);
    }
}
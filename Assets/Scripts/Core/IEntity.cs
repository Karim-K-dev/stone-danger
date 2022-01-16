using Core.Components;

namespace Core
{
    public interface IEntity
    {
        IComponentCollection Components { get; }
    }
}
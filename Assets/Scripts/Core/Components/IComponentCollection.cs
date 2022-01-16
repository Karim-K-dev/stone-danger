using System.Collections.Generic;

namespace Core.Components
{
    public interface IComponentCollection : IReadOnlyCollection<IComponent>
    {
        IEnumerable<T> Get<T>();
    }
}
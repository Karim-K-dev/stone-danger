using Core;
using UnityEngine;

namespace UnityExtensions.Avatars
{
    public static class GameObjectExt
    {
        public static IAvatar GetAvatar(this GameObject gameObject)
        {
            var success = gameObject.TryGetComponent<IAvatar>(out var avatar);
            if (success)
            {
                return avatar;
            }

            return null;
        }
    }
}
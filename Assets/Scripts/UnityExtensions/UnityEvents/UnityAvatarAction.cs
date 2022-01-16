using UnityEngine.Events;
using System;
using Core;

namespace UnityExtensions.UnityEvents
{
    [Serializable]
    public class UnityAvatarAction : UnityEvent<IAvatar>
    {
    }
}
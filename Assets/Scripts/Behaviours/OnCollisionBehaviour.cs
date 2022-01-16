using UnityEngine;
using UnityExtensions.Avatars;
using UnityExtensions.UnityEvents;

namespace Behaviours
{
    public class OnCollisionBehaviour : MonoBehaviour
    {
        [SerializeField]
        private UnityAvatarAction CollisionEnter2D;

        private void OnCollisionEnter2D(Collision2D other)
        {
            var otherAvatar = other.gameObject.GetAvatar();
            CollisionEnter2D.Invoke(otherAvatar);
        }
    }
}
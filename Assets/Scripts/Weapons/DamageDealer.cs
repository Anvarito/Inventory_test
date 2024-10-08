using Damage;
using UnityEngine;
using UnityEngine.Events;

namespace Weapons
{
    public class DamageDealer : MonoBehaviour
    {
        public UnityAction<EnemyDamageRecivier> OnDamage;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.TryGetComponent(out EnemyDamageRecivier enemyDamageRecivier))
            {
                OnDamage?.Invoke(enemyDamageRecivier);
            }
        }
    }
}
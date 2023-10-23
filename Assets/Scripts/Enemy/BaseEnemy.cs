using UnityEngine;
using Health;
using UnityEngine.Events;

namespace Enemy
{
    public class BaseEnemy : MonoBehaviour, IHealthComponent
    {
        [SerializeField] protected EnemySO enemyType;
        [SerializeField] protected UnityEvent onDamage;
        [SerializeField] public UnityEvent<GameObject> onDeath;
        [SerializeField] protected Animator _animator;
        private float currentHealth;
        protected bool isAlive;
        private static readonly int Death1 = Animator.StringToHash("Death");
        private static readonly int Damage1 = Animator.StringToHash("Damage");
        private BoxCollider boxCollider;
        
        public float MoveSpeed { get => enemyType.moveSpeed; }
        public float Damage { get => enemyType.damage;  }
        public float AttackSpeed { get => enemyType.attackSpeed;  }
        public float AttackRange { get => enemyType.attackRange;  }
        public float CurrentHealth { get => currentHealth; set => currentHealth = value; }
        public float DeathTime { get => enemyType.deathTime; }

        private void Start()
        {
            CurrentHealth = enemyType.maxHealth;
            boxCollider = GetComponent<BoxCollider>();
            isAlive = true;
        }
        public virtual void Death()
        {
            _animator?.SetTrigger(Death1);
            boxCollider.enabled = false;
            Invoke(nameof(DestroyEnemy),DeathTime);
        }

        private void DestroyEnemy()
        {
            onDeath.Invoke(this.gameObject);
        }

        public virtual bool IsAlive()
        {
            return isAlive;
        }

        public virtual void ReceiveDamage(float damage)
        {
            _animator?.SetTrigger(Damage1);
            CurrentHealth -= damage;
            onDamage.Invoke();
            if (CurrentHealth <= 0)
            {
                isAlive = false;
                Death();
            }
        }
    }

}

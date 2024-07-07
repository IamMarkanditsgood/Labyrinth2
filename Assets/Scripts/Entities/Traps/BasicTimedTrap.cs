using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Entities.Traps
{
    public abstract class BasicTimedTrap : BasicTrap
    {
        [SerializeField] private float _attackTimer;

        private void Start()
        {
            Init();
        }
        public override void Init()
        {
            base.Init();
            StartCoroutine(AttackRoutine());
        }

        public abstract void Attack();

        private IEnumerator AttackRoutine()
        {
            while (true)
            {
                yield return new WaitForSeconds(_attackTimer);            
                Attack();
            }
        }
    }
}
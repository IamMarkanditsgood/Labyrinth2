using UnityEngine;

namespace Assets.Scripts.Entities.Ball
{
    public class Ball : MonoBehaviour, IDamageable, IInitializable
    {
        [SerializeField] private float _hp = 100;
        public void Init()
        {

        }

        public void GetDamage(float damage)
        {
            _hp -= damage;
            Debug.Log($"hp: {_hp}");
        }
    }
}
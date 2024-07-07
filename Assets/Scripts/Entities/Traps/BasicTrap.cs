using Assets.Scripts.Entities.Ball;
using UnityEngine;

public abstract class BasicTrap : MonoBehaviour, IInitializable
{
    [SerializeField] private float _damage;

    public virtual void Init()
    {       
    }

    public void DamagePlayer(IDamageable ball)
    {
        ball.GetDamage(_damage);
    }
}
using Assets.Scripts.Entities.Ball;
using Assets.Scripts.Entities.Traps;
using UnityEngine;

public class Peaks : BasicTimedTrap
{
    [SerializeField] private BoxCollider _boxCollider;
    public override void Attack()
    {
        if (!_boxCollider.enabled)
        {
            _boxCollider.enabled = true;
        }
        else
        {
            _boxCollider.enabled = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<IDamageable>() != null)
        {
            DamagePlayer(collision.gameObject.GetComponent<IDamageable>());
        }
    }
}

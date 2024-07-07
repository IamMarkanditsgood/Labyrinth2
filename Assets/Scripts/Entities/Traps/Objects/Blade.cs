using Assets.Scripts.Entities.Ball;
using UnityEngine;

public class Blade : BasicTrap
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<IDamageable>() != null)
        {
            DamagePlayer(collision.gameObject.GetComponent<IDamageable>());
        }
    }
}

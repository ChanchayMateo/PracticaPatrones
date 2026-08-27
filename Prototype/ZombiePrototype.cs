using UnityEngine;

public class ZombiePrototype : EnemyPrototype
{
    public override void Attack()
    {
        Debug.Log("Zombie attacks | HP: " + health + " | Damage: " + damage);
    }
}
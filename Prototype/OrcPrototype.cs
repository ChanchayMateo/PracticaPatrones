using UnityEngine;

public class OrcPrototype : EnemyPrototype
{
    public override void Attack()
    {
        Debug.Log("Orc attacks | HP: " + health + " | Damage: " + damage);
    }
}
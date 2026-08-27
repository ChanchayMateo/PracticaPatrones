using UnityEngine;

public class ZombieEnemyBuilder : EnemyBuilder
{
    public override void Create(Vector3 position)
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        obj.name = "Zombie6";
        obj.transform.position = position;
        enemy = obj.AddComponent<Enemy6>();
        SpriteRenderer renderer = obj.AddComponent<SpriteRenderer>();
        renderer.sortingOrder = 11;

    }
    public override void AddStats()
    {
        enemy.setStats(120, 15);
    }
    public override void AddWeapon()
    {
        enemy.SetWeapon("Claws");
    }
}
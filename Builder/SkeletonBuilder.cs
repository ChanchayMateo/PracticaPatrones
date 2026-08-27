using UnityEngine;

public class SkeletonEnemyBuilder : EnemyBuilder
{
    public override void Create(Vector3 position)
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "Skeleton6";
        obj.transform.position = position;
        
        enemy = obj.AddComponent<Enemy6>();
    }

    public override void AddStats()
    {
        enemy.setStats(80, 25);
    }

    public override void AddWeapon()
    {
        enemy.SetWeapon("Bow");
    }
}
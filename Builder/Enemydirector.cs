using UnityEngine;

public class EnemyDirector
{
    public Enemy6 Build(EnemyBuilder builder, Vector3 position)
    {
        builder.Create(position);
        builder.AddStats();
        builder.AddWeapon();
        return builder.GetResult();
    }
}
using UnityEngine;

public abstract class EnemyBuilder
{
    protected Enemy6 enemy;

    public abstract void Create(Vector3 position);
    public abstract void AddStats();
    public abstract void AddWeapon();

    public virtual Enemy6 GetResult() => enemy;
}


using UnityEngine;

public abstract class EnemySpawner
{
    public void SpawnEnemy()
    {
        Enemy4 enemy = CreateEnemy();
        enemy.Spawn();
    }
    protected abstract Enemy4 CreateEnemy();
}
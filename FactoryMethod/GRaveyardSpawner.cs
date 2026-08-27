using UnityEngine;

public class GraveyardSpawner : EnemySpawner
{
    protected override Enemy4 CreateEnemy()
    {
        return new Zombie4();
        
    }
}
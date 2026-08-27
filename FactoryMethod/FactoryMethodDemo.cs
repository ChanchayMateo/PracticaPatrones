using UnityEngine;

public class FactoryMethodDemo : MonoBehaviour
{
    private void Start()
    {
        EnemySpawner spawner = new SlimeFactory();
        spawner.SpawnEnemy();
    }
}
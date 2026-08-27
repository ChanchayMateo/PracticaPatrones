using UnityEngine;

public class PrototypeDemo : MonoBehaviour
{
    [SerializeField] private EnemyPrototype prototype;
    [SerializeField] private Transform spawnPoint;

    [ContextMenu("Spawn Clone")]
    private void SpawnClone()
    {
        EnemyPrototype clone = prototype.Clone(spawnPoint.position, spawnPoint.rotation);
        clone.Attack();
    }
}
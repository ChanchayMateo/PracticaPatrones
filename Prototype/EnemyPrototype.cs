using UnityEngine;

public abstract class EnemyPrototype : MonoBehaviour
{
    [SerializeField] protected int health = 100;
    [SerializeField] protected int damage = 10;

    public virtual EnemyPrototype Clone(Vector3 position, Quaternion rotation)

    {
        EnemyPrototype copy = Instantiate(this,position, rotation);
        copy.gameObject.SetActive(true);
        return copy;
    }

    public abstract void Attack();
}
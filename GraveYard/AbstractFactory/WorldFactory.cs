using   UnityEngine;

public abstract class WorldFactory : MonoBehaviour
{
    public abstract Enemy CreateEnemy(Vector3 position);
    public abstract Weapon CreateWeapon(Vector3 position);
}
using UnityEngine;

public class GraveyardFactory : WorldFactory
{
    private GameObject zombiePrefab;
    private GameObject ghostPrefab;
    private GameObject swordPrefab;
    private void Awake()
    {
        zombiePrefab = Resources.Load<GameObject>("Graveyard/Zombie");
        ghostPrefab = Resources.Load<GameObject>("Graveyard/Ghost");
        swordPrefab = Resources.Load<GameObject>("Graveyard/RustySword");
    }
    public override Enemy CreateEnemy(Vector3 position) //llamar a con create enemy a un cuadrito
    {
        GameObject prefab = Random.value < 0.5f ? zombiePrefab : ghostPrefab;
        return Instantiate(prefab, position, Quaternion.identity).GetComponent<Enemy>();
    }

    public override Weapon CreateWeapon(Vector3 position)
    {
        return Instantiate(swordPrefab, position, Quaternion.identity).GetComponent<Weapon>();
    }
}
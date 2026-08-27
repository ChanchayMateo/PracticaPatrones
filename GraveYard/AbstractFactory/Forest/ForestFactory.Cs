using UnityEngine;

public class ForestFactory : WorldFactory
{
    private GameObject goblinPrefab;
    private GameObject wolfPrefab;
    private GameObject woodenSwordPrefab;

    private void Awake()
    {
        goblinPrefab = Resources.Load<GameObject>("GraveYard/Goblin");
        wolfPrefab = Resources.Load<GameObject>("GraveYard/Wolf");
        woodenSwordPrefab = Resources.Load<GameObject>("GraveYard/WoodenSword");
    }

    public override Enemy CreateEnemy(Vector3 position)
    {
        GameObject prefab = Random.value < 0.5f ? goblinPrefab : wolfPrefab;

        return Instantiate(prefab, position, Quaternion.identity)
            .GetComponent<Enemy>();
    }

    public override Weapon CreateWeapon(Vector3 position)
    {
        return Instantiate(
            woodenSwordPrefab,
            position,
            Quaternion.identity
        ).GetComponent<Weapon>();
    }
}
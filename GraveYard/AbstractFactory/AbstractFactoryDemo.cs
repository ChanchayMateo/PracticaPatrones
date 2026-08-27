using UnityEngine;

public class AbstractFactoryDemo : MonoBehaviour
{
    [SerializeField] private WorldFactory factory;

    private void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            Enemy enemy = factory.CreateEnemy( new Vector3 (i * 2f, 0f, 0f));
            enemy.Attack();
        }

        Weapon weapon = factory.CreateWeapon(new Vector3(1f, 0.5f, 0f));
        weapon.Use();

    }
}
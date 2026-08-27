using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected string characterName = "Warrior";
    [SerializeField] protected int damage = 20;

    [SerializeField] protected string characterName1 = "Mage";

    public abstract void Attack();
    public virtual void ShowInfo()
    {
        Debug.Log(characterName + " | Damage: " + damage);
        Debug.Log(characterName1 + " | Damage: " + damage);
    }
}


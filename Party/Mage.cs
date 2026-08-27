using UnityEngine;

public class Mage : Character
{
    public override void Attack()
    {
        Debug.Log(characterName1 + " casts a fireball for " + damage + " damage!");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created

}

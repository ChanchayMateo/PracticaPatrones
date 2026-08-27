using UnityEngine;

public class Warrior : Character
{
    public override void Attack()
    {
        Debug.Log(characterName + " attacks with a sword for " + damage + " damage!");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created

}

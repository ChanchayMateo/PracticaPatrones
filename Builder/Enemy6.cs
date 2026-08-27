using UnityEngine;

public class Enemy6 : MonoBehaviour
{
    public int Health {get; private set; }
    public int Damage {get; private set; }
    public string Weapon {get; private set; }

    public void setStats(int health, int damage)
    {
        Health = health;
        Damage = damage;
    }

    public void SetWeapon(string weapon)
    {
        Weapon = weapon;
    }

    public void Print()
    {
        Debug.Log(name +  " | HP: " + Health +
    " | DMG: " + Damage + " | Weapon: " + Weapon); 
    }
}

using UnityEngine;

public class Zombie4 : Enemy4
{
    public override void Spawn()
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        obj.name = "Zombie";
    }
}
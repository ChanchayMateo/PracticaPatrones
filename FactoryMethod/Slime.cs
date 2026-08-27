using UnityEngine;

public class Slime : Enemy4
{
    public override void Spawn() 
    {
        GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        obj.name = "Slime";
        obj.GetComponent<Renderer>().material.color = Color.blue;
        Renderer rend = obj.GetComponent<Renderer>();
        rend.sortingOrder = 10;
    }
}
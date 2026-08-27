using System.Collections.Generic;
using UnityEngine;

public class Party : MonoBehaviour
{
    [SerializeField] private List<Character> _party = new();
    private void Start()
    {
        foreach (var member in _party)
        {
            member.ShowInfo();
            member.Attack();
        }
    }
}
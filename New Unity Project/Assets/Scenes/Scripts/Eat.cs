using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/Eat")]
public class Eat : Goods
{
    public float Mass => _mass;
    [SerializeField] private float _mass;

    public override void Use()
    {
        Debug.Log("game over");
    }
}
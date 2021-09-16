using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/Candle")]
public class Candle : Goods
{
    public float BrightRadius => _brightradius;
    [SerializeField] private float _brightradius;
    public override void Use()
    {
        throw new System.NotImplementedException();
    }
    
}

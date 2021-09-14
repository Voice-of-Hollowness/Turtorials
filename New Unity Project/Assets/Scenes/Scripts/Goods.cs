using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goods
{
    [SerializeField] private string _name;
    [SerializeField] private int _price;

    public string Name {get => Name; set => _name = value; }
    public int Price { get => _price; set => _price = value; }
}

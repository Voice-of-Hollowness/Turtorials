using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(menuName = "Shop/Goods")]

public abstract class Goods : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private int _price;

    public string Name {get => Name; set => _name = value; }
    public int Price { get => _price; set => _price = value; }

    public abstract void Use();
}


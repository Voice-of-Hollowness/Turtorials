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


//���� ������� ���� ����� � ��������� ����, � ������ ������ ��� �������
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


//���� ����, ������ ��� ����� ����� ��������
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

// ����� ���� ��� �������� ��������� ����� ��� ���, �� � ScriptableObject'�� ���� ����� ������� ����� ��������� ���� (� ����������)


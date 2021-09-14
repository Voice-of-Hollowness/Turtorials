using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Chest : LootNode
{
    private List<GameObject> _items = new List<GameObject>();

    public void Open()
    {
        _items.ForEach(x=> x.SetActive(true));
    }

    protected override void PopulateItem(GameObject item)
    {
       base.PopulateItem(item); 

       _items.Add (item);
       item.SetActive(false);
    }

}

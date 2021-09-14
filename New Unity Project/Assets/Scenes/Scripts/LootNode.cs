
using UnityEngine;


public class LootNode : MonoBehaviour
{
    [SerializeField]
    private int _weaponChance;
    [SerializeField]
    private int _armorChance;

    public void Start()
    {
        var item = GetRandomItem();
        PopulateItem(item);
    }
    protected virtual void PopulateItem(GameObject item)
    {
        item.transform.parent = item.transform;
        item.transform.localPosition = Vector3.zero;
    }

    protected GameObject GetRandomItem()
    {

        return new GameObject("Item"+Random.Range(0,100)) ;
    }
}

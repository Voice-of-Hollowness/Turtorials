using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerChest : MonoBehaviour,IInteracterable
{
    private Incapsulation _target;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,_target.transform.position,_target.Speed* Time.deltaTime*0.9f);
    }

    public void Action(Incapsulation player)
    {
        _target = player;
    }
}

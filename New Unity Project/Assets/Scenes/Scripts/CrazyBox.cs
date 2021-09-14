using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyBox : MonoBehaviour, IInteracterable
{

    public void Action(Incapsulation player)
    {
       Debug.Log("Crazy Box");
    }
}


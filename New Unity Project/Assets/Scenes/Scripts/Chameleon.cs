using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chameleon : MonoBehaviour, IInteracterable
{

    public void Action(Incapsulation player)
    {
        GetComponent<MeshRenderer>().sharedMaterial.color = Random.ColorHSV();
    }
}



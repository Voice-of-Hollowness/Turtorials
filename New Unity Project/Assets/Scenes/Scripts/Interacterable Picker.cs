using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracterablePicker : MonoBehaviour
{
    [SerializeField] private Camera _inputCamera;
    [SerializeField] private Incapsulation _player;

    private void Update()
    {
        var ray = _inputCamera.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y,
            Input.mousePosition.z));
        var raycastHit = new RaycastHit();

        if (Physics.Raycast(ray, out raycastHit))
        {
            var interactable = raycastHit.collider.GetComponent<IInteracterable>();
            if (interactable != null)
                interactable.Action(_player);

        }
    }
}


using System;
using UnityEngine;

public class Incapsulation : MonoBehaviour
{

    [SerializeField]
    private float speed;

    private Vector3 _direction;

    public float Speed => speed;

    #region MonoBehavior

    private void OnValidate()
    {
        if (speed < 0)
        {
            speed = 0;
        }
    }

    #endregion
    

    public void TurnLeft()
    {
    }
    public void TurnRight()
    {
    }
    public void MoveForward()
    {
    }
}

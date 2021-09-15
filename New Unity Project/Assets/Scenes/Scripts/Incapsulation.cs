
using System;
using UnityEngine;

public class Incapsulation : MonoBehaviour
{

    [SerializeField]  private float speed;
    [SerializeField] private IWeapon _currentWeapon;
    [SerializeField] private GameObject _weapon;


    private Vector3 _direction;

    public float Speed => speed;

    #region MonoBehavior

    private void OnValidate()
    {
        if (speed < 0)
            speed = 0;

        if (_weapon != null && _weapon.GetComponent<IWeapon>() == null) _weapon = null;


    }

    private void Start()
    {
        if (_weapon != null)
        
        _currentWeapon = _weapon.GetComponent<IWeapon>();
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

    public interface IWeapon
    {
        void Shoot();
    }

}
public abstract class AbstractWeapon : MonoBehaviour
{
    
}


using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Incapsulation : MonoBehaviour
{
    public UnityEvent OnFalled;
    [SerializeField]  private float speed;
    [SerializeField] private IWeapon _currentWeapon;
    [SerializeField] private GameObject _weapon;

    private Rigidbody _rigidbody;
    private Vector3 _direction;

    

    public float Speed => speed;
    public Vector3 _lastVelocity;

    #region MonoBehavior

    private void OnValidate()
    {
        if (speed < 0)
            speed = 0;

        if (_weapon != null && _weapon.GetComponent<IWeapon>() == null) _weapon = null;

        _rigidbody = GetComponent<Rigidbody>();


    }

    private void Start()
    {
        if (_weapon != null)
        
        _currentWeapon = _weapon.GetComponent<IWeapon>();

    }

    private void FixedUpdate()
    {
        if ((_lastVelocity - _rigidbody.velocity).magnitude > 5)
            OnFalled.Invoke();

        //закрыли модуль для модификаций и открыли для расширений

        _lastVelocity = _rigidbody.velocity;
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


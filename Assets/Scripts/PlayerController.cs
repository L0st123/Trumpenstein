using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    private float rotationSpeed; 
    [SerializeField] private float _moveSpeed;
    private float health; 

    private void FixedUpdate()
    {
      
        _rigidbody.linearVelocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.linearVelocity.y, _joystick.Vertical * _moveSpeed);
        Quaternion toRotation = Quaternion.LookRotation(_rigidbody.linearVelocity, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    // need to find veritcal and rotation of camera
            
    }
}

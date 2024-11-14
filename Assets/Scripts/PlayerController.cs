using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class PlayerController : MonoBehaviour 
{
    [SerializeField] private Rigidbody rb;
    [SerializeField]   private FixedJoystick joystick;
    //animator if i need one

    [SerializeField] private float _moveSpeed;

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(joystick.Horizontal * _moveSpeed, rb.linearVelocity.y, joystick.Vertical * _moveSpeed); 
    }
}

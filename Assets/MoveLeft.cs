using Unity.VisualScripting;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5f;
    public GameObject player; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveCameraLeft();
    }

    void MoveCameraLeft()
    {
        
        transform.Rotate(0, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);
    }
        
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerMove : MonoBehaviour
{
    
    public FixedJoystick joystick;
    public float SpeedMove = 5f;
    private CharacterController controller;
    public float health; 
    void Start()
    {
        health = 100f;
        controller= GetComponent<CharacterController>();
    }

    
    void Update()
    {
        Vector3 Move = transform.right * joystick.Horizontal + transform.forward * joystick.Vertical;
        controller.Move(Move * SpeedMove * Time.deltaTime);
    }
    public void healthTaker()
    {
        if (health == 0f)
        {
            SceneManager.LoadScene("Episode 1");
        }
    }
}

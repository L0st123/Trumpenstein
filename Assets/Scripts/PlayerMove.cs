using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    
    public FixedJoystick joystick;
    public float SpeedMove = 5f;
    private CharacterController controller;
    public string healthValue;
 
    public static PlayerMove instance;
    public GameObject deathScreen;
    public GameObject userInterface;
    public float ammo;  

     
    void Start()
    {
        
        healthCollect.healthValue = 100;
        
        controller = GetComponent<CharacterController>();

        
    }
    public void Awake()
    {
        
        instance = this;
    }


    void Update()
    {
        Vector3 Move = transform.right * joystick.Horizontal + transform.forward * joystick.Vertical;
        controller.Move(Move * SpeedMove * Time.deltaTime);
        healthTaker();
      
    }

    public void KillEnemy()
    {
        
    }
    public void healthTaker()
    {
        if (healthCollect.healthValue <= 0f)
        {
            Debug.Log("player died");
            SceneManager.LoadScene("DeathScreen");

        }
    }

    public void DoDamage( int amount )
    {
        healthCollect.healthValue -= amount;


        Debug.Log("playerHealth" + healthCollect.healthValue);

        
    }
}

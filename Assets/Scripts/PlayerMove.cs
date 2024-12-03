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
    public float playerHealth;
    public string healthValue;
    public Text textElement;
    public static PlayerMove instance;
    public GameObject deathScreen;
    public GameObject userInterface;
    public float ammo;  

     
    void Start()
    {
        
        playerHealth = 100f;
        healthValue = playerHealth.ToString();
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
        textElement.text = healthValue;
    }

    public void KillEnemy()
    {
        
    }
    public void healthTaker()
    {
        if (playerHealth <= 0f)
        {
            Debug.Log("player died");
            userInterface.SetActive(false);
            deathScreen.SetActive(true);

        }
    }

    public void DoDamage( int amount )
    {
        playerHealth -= amount;


        Debug.Log("playerHealth" + playerHealth);

        healthValue = playerHealth.ToString();
    }
}

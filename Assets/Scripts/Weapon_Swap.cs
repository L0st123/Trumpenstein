using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Weapon_Swap : MonoBehaviour
{
    public GameObject pistol;
    public GameObject knife;
    public GameObject machineGun;
    public GameObject weapon;
    public static Weapon_Swap instance;
    public GameObject pistolButton; 
    public GameObject machineGunButton;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        machineGun.SetActive(false);
    }
     void Awake()
    {
        instance = this;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        pistolButton.SetActive(false ); 
        machineGunButton.SetActive(true );
        machineGun.SetActive(true);    
        Destroy(pistol);
        knife.SetActive(false);
       
        
            

        if (machineGun == true)
        {
            weapon.SetActive(false);
            GetComponent<Collider>().enabled = false;
        }
       
        


    }
     
}

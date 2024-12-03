using UnityEngine;

public class Weapon_Swap : MonoBehaviour
{
    public GameObject Pistol;
    public GameObject Knife;
    public GameObject MachineGun;
    public GameObject weapon;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MachineGun.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
            Knife.SetActive(false);
            MachineGun.SetActive(true);
            Pistol.SetActive(false);
            

        if (MachineGun == true)
        {
            weapon.SetActive(false);
            GetComponent<Collider>().enabled = false;
        }
       
        


    }
     
}

using UnityEngine;

public class Weapon_Swap : MonoBehaviour
{
    public GameObject Pistol;
    public GameObject Knife;
    public GameObject MachineGun;
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<KnifeScript>();    
        GetComponent<MachineGunScript>();
        GetComponent<PistolScript>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void PlayAnimation()
    {
        
        if (Pistol && MachineGun == null)
        {
            Knife.SetActive(true);
            MachineGun.SetActive(false);
            Pistol.SetActive(false);
        }

    }
}

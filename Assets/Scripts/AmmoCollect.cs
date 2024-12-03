using UnityEngine;
using UnityEngine.UI;

public class AmmoCollect : MonoBehaviour
{

    public GameObject ammoDisplay;
    public static int ammoValue = 0;
    public int internalAmmo;
    public GameObject pistol;
    public GameObject machineGun;
    public GameObject knife; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        internalAmmo = ammoValue;
        ammoDisplay.GetComponent<Text>().text = "" + ammoValue;
        
        if (ammoValue ==  0)
        {
            pistol.SetActive(false);
            machineGun.SetActive(false);    
            knife.SetActive(true);
        }
        if (ammoValue >= 1)
        {
            pistol.SetActive(true);
            knife.SetActive(false);
            machineGun.SetActive(false);
        }
    }
}

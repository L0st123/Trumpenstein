using NUnit.Framework.Internal.Filters;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AmmoBox : MonoBehaviour
{
    

 
    public Text textElement;
    public GameObject ammoBox;
    public GameObject pickUpDisplay;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
        
    }
    void OnTriggerEnter(Collider other)
    {
        pickUpDisplay.SetActive(true);
        ammoBox.SetActive(false);
       GetComponent<Collider>().enabled = false;

        AmmoCollect.ammoValue += 3;
        print("ammo +3");
     


        pickUpDisplay.SetActive(false);





    }






}

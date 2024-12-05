using NUnit.Framework.Internal.Filters;
using System;
using UnityEngine;
using UnityEngine.UI;

public class healthBox : MonoBehaviour
{



    public Text textElement;
    public GameObject healthBoxlol;
    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


    }
    void OnTriggerEnter(Collider other)
    {
        
        healthBoxlol.SetActive(false);
        GetComponent<Collider>().enabled = false;

        healthCollect.healthValue += 15;
        print("health +15");









    }
}
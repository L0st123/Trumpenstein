using UnityEngine;
using TMPro;

public class healthCollect : MonoBehaviour

{
    public GameObject healthDisplay;
    public static int healthValue = 0;
    public int internalHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalHealth = healthValue;
        healthDisplay.GetComponent<TextMeshProUGUI>().text = "" + healthValue;
    }
}

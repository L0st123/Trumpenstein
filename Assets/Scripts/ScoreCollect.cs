using UnityEngine;
using TMPro;

public class ScoreCollect : MonoBehaviour
{
    public GameObject scoreDisplay; 
    public static int scoreValue = 000;
    public int internalScore; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalScore = scoreValue;
        scoreDisplay.GetComponent<TextMeshProUGUI>().text = "" + scoreValue;
    }
}

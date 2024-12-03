using UnityEngine;
using UnityEngine.UI;

public class ScoreCollect : MonoBehaviour
{
    public GameObject scoreDisplay; 
    public static int scoreValue = 0;
    public int internalScore; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        internalScore = scoreValue;
        scoreDisplay.GetComponent<Text>().text = "" + scoreValue;
    }
}

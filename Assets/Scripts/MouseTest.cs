using UnityEngine;

public class MouseTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetMouseButtonDown(0) )
        {
            print("mouse pressed");

        }

    }

    public void OnMouseDown()
    {
    }
}

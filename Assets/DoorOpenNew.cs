using UnityEngine;

public class DoorOpenNew : MonoBehaviour
{

    public Animator animator;
    public bool door;
    // public AudioSource DoorOpen;



    void Start()
    {
        door = false;
        animator.SetBool("Open", false);


        print("Start door open new");
    }
    private void Update()
    {
        CheckForDoor(); 
    }

    public void CheckForDoor()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("mouse pressed");
            door = true;

            animator.SetBool("Open", true);
            Debug.Log(gameObject.name + " is pressed");
        }
        
        



        // DoorOpen.Play();

    }


}
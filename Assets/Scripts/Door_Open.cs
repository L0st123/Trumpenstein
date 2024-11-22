using UnityEngine;

public class Door_Open : MonoBehaviour
{

    public Animator animator;
    public bool door;
   // public AudioSource DoorOpen;



    void Start()
    {
        door = false;
        animator.SetBool("Open", false);
    }

    private void OnMouseDown()
    {
        Debug.Log(gameObject.name + " is pressed");
        door = true;
        animator.SetBool("Open", true);
      // DoorOpen.Play();

    }


}

using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_Open : MonoBehaviour
{

    public Animator animator;
    public bool door;
   // public AudioSource DoorOpen;



    void Start()
    {
        door = false;
    }
   
    public void OnMouseDown()
    {
        animator.SetTrigger("Open");
        Debug.Log(gameObject.name + " is pressed");
        door =true;
        
        // DoorOpen.Play();

    }


}

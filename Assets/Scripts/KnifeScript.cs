using UnityEngine;

public class KnifeScript : MonoBehaviour
{
    Animator animator;
    bool attack; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void  PlayAnimation()
    {
        Debug.Log("Attacking");
        animator.SetTrigger("Attack"); 
    }
}

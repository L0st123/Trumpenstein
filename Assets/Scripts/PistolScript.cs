using UnityEngine;
using UnityEngine.UI;

public class PistolScript : MonoBehaviour
{
   public Animator animator;
   public bool attack;
  
    public Button button;
    public GameObject pistol;
    public GameObject knife;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AmmoCollect.ammoValue = 8;
        animator = gameObject.GetComponent<Animator>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AmmoCollect.ammoValue == 0)
        {
            knife.SetActive(true);
            pistol.SetActive(false);
        }
    }
    public void  PlayAnimation()
    {
        PlayerScript.playerIsAttacking=true;
        
        Debug.Log("Attacking");
        animator.SetTrigger("Attack");
       
        AmmoCollect.ammoValue -= 1;

       
        
       
    }
    public void enemyDamage()
    {
       
      
        
    }


    void CheckForEnemyHit()
    {
        
    }
}

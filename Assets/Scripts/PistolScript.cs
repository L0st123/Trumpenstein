using Unity.Notifications.iOS;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PistolScript : MonoBehaviour
{
   public Animator animator;
   public bool attack;
  
    public Button button;
    public GameObject pistol;
    public GameObject knife;
    AudioManagerScript audioManagerScript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AmmoCollect.ammoValue = 8;
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
        enemyDamage();
        AmmoCollect.ammoValue -= 1;

        audioManagerScript.PlaySFX(2);
        
        if (AmmoCollect.ammoValue == 0f)
        {
            pistol.SetActive(false);
            knife.SetActive(true); 
        }
    }
    public void enemyDamage()
    {
        if (EnemyAttack.instance.playerInAttackRange && button != null)
        {
            EnemyAttack.instance.TakeDamage(15);
        }
    }
}

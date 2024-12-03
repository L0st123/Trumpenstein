using UnityEngine;
using UnityEngine.UI;

public class KnifeScript : MonoBehaviour
{
    Animator animator;
    string attack;
    public Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AmmoCollect.ammoValue = 0;
     

        
        animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void PlayAnimation()
    {
        if (animator == null)
        {
            return;
        }
        Debug.Log("Attacking");
        animator.SetTrigger("Attack");
        AmmoCollect.ammoValue =+ 0;
        enemyDamage();
        Debug.Log(EnemyAttack.instance.enemyHealth);
    }

    public void enemyDamage()
    {
        if (EnemyAttack.instance.playerInAttackRange && button != null)
        {
            EnemyAttack.instance.TakeDamage(10);
        }
    }
}

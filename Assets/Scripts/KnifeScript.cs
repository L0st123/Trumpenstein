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
        AmmoCollect.ammoValue = AmmoCollect.ammoValue + 0;

        animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        AmmoCollect.ammoValue = AmmoCollect.ammoValue + 0;
    }
    public void PlayAnimation()
    {
        
        
        Debug.Log("Attacking");
        animator.SetTrigger("Attack");
        
        enemyDamage();
        Debug.Log(EnemyAttack.instance.enemyHealth);
    }

    public void enemyDamage()
    {
        if (EnemyAttack.instance.playerInAttackRange && button != null)
        {
            EnemyAttack.instance.TakeDamage(10);
        }
        if (bossScript.instance.playerInAttackRange && button != null)
        {
            bossScript.instance.TakeDamage(10);


        }
    }
}

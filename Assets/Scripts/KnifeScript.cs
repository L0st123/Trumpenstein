using UnityEngine;
using UnityEngine.UI;

public class KnifeScript : MonoBehaviour
{
    Animator animator;
    string attack;
    public float ammo;
    public string ammoValue;
    public string textValue;
    public Text textElement;
    public Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ammoValue = ("N/A");
        textElement.text = ammoValue;
        
        animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = ammoValue;
    }
    public void PlayAnimation()
    {
        if (animator == null)
        {
            return;
        }
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
    }
}

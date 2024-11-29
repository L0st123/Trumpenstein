using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PistolScript : MonoBehaviour
{
   public Animator animator;
   public bool attack;
    public float ammo;
    public string ammoValue;
   
    public Text textElement;
    public Button button;
    public GameObject pistol;
    public GameObject knife; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ammo = 8f;
        ammoValue = ammo.ToString();    
        textElement.text = ammoValue;   
        
        animator = gameObject.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = ammoValue;   
    }
    public void  PlayAnimation()
    {
        Debug.Log("Attacking");
        animator.SetTrigger("Attack");
        enemyDamage();
        ammo = ammo - 1f;
        ammoValue = ammo.ToString();
        if (ammo == 0f)
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

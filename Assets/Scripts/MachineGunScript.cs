using UnityEngine;
using UnityEngine.UI;

public class MachineGunScript : MonoBehaviour
{
    public Animator animator;
    public float ammo;
    public GameObject machineGun;
    public GameObject knife;
    public GameObject pistol;
    public Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        machineGun.SetActive(true);
        AmmoCollect.ammoValue = 6;
        
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
        enemyDamage();
        AmmoCollect.ammoValue -= 1;
        if (ammo == 0f)
        {
            machineGun.SetActive(false);
            pistol.SetActive(false);
            knife.SetActive(true);
        }

    }
    public void enemyDamage()
    {
        if (EnemyAttack.instance.playerInAttackRange && button != null)
        {
            EnemyAttack.instance.TakeDamage(20);
        }
    }
}

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
       
        AmmoCollect.ammoValue = 35;
        
        animator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (AmmoCollect.ammoValue == 0)
        {
            knife.SetActive(true);
            machineGun.SetActive(false);
        }
    }
    public void PlayAnimation()
    {
        PlayerScript.playerIsAttacking = true;
        Debug.Log("Attacking");
        animator.SetTrigger("Attack");
        enemyDamage();
        AmmoCollect.ammoValue -= 1;

        if (AmmoCollect.ammoValue == 0)
        {
            knife.SetActive(true);
            machineGun.SetActive(false);
        } 

    }
    public void enemyDamage()
    {
    }
}

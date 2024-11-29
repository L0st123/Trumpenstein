using UnityEngine;
using UnityEngine.UI;

public class MachineGunScript : MonoBehaviour
{
    Animator animator;
    public float ammo;
    public string ammoValue;
    public string textValue;
    public Text textElement;
    public GameObject machineGun;
    public GameObject knife;
    public Button button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ammo = 6f;
        ammoValue = ammo.ToString();
        textElement.text = textValue;

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
        ammo = ammo - 1;
        if (ammo == 0f)
        {
            machineGun.SetActive(false);
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

using UnityEngine;
using UnityEngine.UI;

public class MachineGunScript : MonoBehaviour
{
    Animator animator;
    bool attack;
    public float ammo;
    public string ammoValue;
    public string textValue;
    public Text textElement;
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
        ammo = ammo - 1;
    }
}

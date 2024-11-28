using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PistolScript : MonoBehaviour
{
   public Animator animator;
   public bool attack;
    public float ammo;
    public string ammoValue;
   public string textValue;
    public Text textElement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ammo = 8f;
        ammoValue = ammo.ToString();    
        textElement.text = textValue;   
        
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
        ammo = ammo - 1; 
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEditor;

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.VFX;



    public class PlayerScript : MonoBehaviour
    {

    [SerializeField] private InputActionReference moveActionToUse;
    [SerializeField ] private float speed; 
    private void Start()
    {
          
     
    }
     void Update()
    {
        Vector3 moveDirection = moveActionToUse.action.ReadValue<Vector3>();
        transform.Translate(moveDirection * speed * Time.deltaTime);
    }


}


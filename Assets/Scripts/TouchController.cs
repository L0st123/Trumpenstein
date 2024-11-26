using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public FixedTouchField _FixedTouchField;
    public CameraLook CameraLook;
    void Start()
    {
        
    }

    
    void Update()
    {
        CameraLook.LockAxis = _FixedTouchField.TouchDist;
    }
}

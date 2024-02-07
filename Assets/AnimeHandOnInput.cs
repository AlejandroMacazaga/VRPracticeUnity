using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimeHandOnInput : MonoBehaviour
{

    public InputActionProperty pinchAction;
    public InputActionProperty gripAction;

    public Animator handAnimator;
    // Start is called before the first frame update
    void Start()
    {
        pinchAction.action.Enable();
        gripAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        handAnimator.SetFloat("Trigger", pinchAction.action.ReadValue<float>());
        handAnimator.SetFloat("Grip", gripAction.action.ReadValue<float>());
    }
    
    
    
}

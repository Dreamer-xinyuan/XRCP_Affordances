using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class HandControllerXRCP : MonoBehaviour
{
    ActionBasedController controller;
    public AnimateHandXRCP hand;//this is our gamobject with the hand animation script


    // Start is called before the first frame update
    private void Awake()
    {
        //get the action based controller
        controller = GetComponent<ActionBasedController>();

    }

    private void OnEnable()
    {
        //subscribe / listen to start and end events on action based controller and set up callbacks
        controller.selectAction.action.started += selectStarted;
        controller.selectAction.action.canceled += selectEnded;

        controller.activateAction.action.started += activateStarted;
        controller.activateAction.action.canceled += activateEnded;
    }


    private void OnDisable()
    {
        //unsubscribe to start and end events 
        controller.selectAction.action.started -= selectStarted;
        controller.selectAction.action.canceled -= selectEnded;

        controller.activateAction.action.started -= activateStarted;
        controller.activateAction.action.canceled -= activateEnded;
    }

    private void selectStarted(InputAction.CallbackContext context)
    {
        hand.SetGripTarget(1);//close fingers 
    }

    private void selectEnded(InputAction.CallbackContext context)
    {
        hand.SetGripTarget(0);//open fingers
    }

    private void activateStarted(InputAction.CallbackContext context)
    {
         hand.SetTriggerTarget(1);//close finger
    }

    private void activateEnded(InputAction.CallbackContext context)
    {
         hand.SetTriggerTarget(0);//open finger
    }


}

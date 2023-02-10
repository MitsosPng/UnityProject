using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator controller = null;
     private bool open = false;
    
    

    public void OnAbortInteract()
    {
        
    }

    public void OnEndInteract()
    {
        
    }

    public void OnInteract(Interactor interactor)
    {
        if (!open)
        {
            controller.Play("Door");
         
            open = true;

        }
        else
        {
            controller.Play("DoorClose");
            open = false;
        }
    }

    public void OnReadyInteract()
    {
        
    }
}

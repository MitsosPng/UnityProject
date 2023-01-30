using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Version 1.2
//A class of a sign, it contains a message for display
public class Lights : MonoBehaviour, IInteractable
{
	[SerializeField] private GameObject light;
    
 

    public void OnInteract(Interactor interactor){
        if (light.GetComponent<Light>().enabled == false){
            light.GetComponent<Light>().enabled = true;
        }
        else
        {
            light.GetComponent<Light>().enabled = false;
        }
       
    
    }	
	
	//unimplemented Methods
    public void OnEndInteract()
    {
    }

    public void OnAbortInteract()
    {

    }

    public void OnReadyInteract()
    {

    }
}

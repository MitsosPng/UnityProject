using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatInteract : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject Route;
    public void OnAbortInteract()
    {
       
    }

    public void OnEndInteract()
    {
      
    }
    public void OnInteract(Interactor interactor)
    {
        if(Route.GetComponent<Dreamteck.Splines.SplineFollower>().enabled == true)
        {
            Route.GetComponent<Dreamteck.Splines.SplineFollower>().enabled = false; ;
        }
        else
        {
            Route.GetComponent<Dreamteck.Splines.SplineFollower>().enabled = true;
        }
    }

    public void OnReadyInteract()
    {
       
    }
  
}

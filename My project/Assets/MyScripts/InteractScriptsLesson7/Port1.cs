using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Port1 : MonoBehaviour
{
    [SerializeField] private GameObject Boat;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boat"))
        {

            if (Boat.GetComponent<Dreamteck.Splines.SplineFollower>().enabled == true)
            {
                Boat.GetComponent<Dreamteck.Splines.SplineFollower>().enabled = false;
            }
        }
    }

}

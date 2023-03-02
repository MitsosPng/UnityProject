using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffMusic : MonoBehaviour
{
    [SerializeField] private GameObject bgMusic;
    private void OnTriggerEnter(Collider other)
    {
     
        if (other.CompareTag("Player"))
        {
            bgMusic.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            bgMusic.SetActive(true);
        }
    }
}

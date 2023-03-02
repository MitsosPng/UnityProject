using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnBGMusic : MonoBehaviour
{
    [SerializeField] private GameObject bgMusic;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Po");
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

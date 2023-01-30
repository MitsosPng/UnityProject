using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject blocker;
    void Start()
    {
        blocker.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartApp()
    {
        blocker.SetActive(true);
        SceneManager.LoadSceneAsync("FantasyLand");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject blocker;
    // Start is called before the first frame update
    void Start()
    {
        blocker.SetActive(false);
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

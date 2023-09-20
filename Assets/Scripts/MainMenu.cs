using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        int Attempts = Singleton.Instance.Attempts;
        Debug.Log(Attempts);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("LEVEL1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

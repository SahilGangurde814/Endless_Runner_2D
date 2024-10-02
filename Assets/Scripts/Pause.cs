using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject PauseMenu;

    //public GameObject Player;

    public void pause()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resume()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}

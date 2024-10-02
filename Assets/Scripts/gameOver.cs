using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{

    public GameObject GameOverPanel;

    public GameObject player;

    public Text scoreText;
    public Text highScoreText;
    public Button upButton;
    public Button downButton;
    public Button pauseButton;

    private bool revived;

    private void Start()
    {
        revived = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            GameOverPanel.SetActive(true);
            upButton.gameObject.SetActive(false);
            downButton.gameObject.SetActive(false);
            pauseButton.gameObject.SetActive(false);
            scoreText.gameObject.SetActive(false);
            highScoreText.gameObject.SetActive(false);

            StartCoroutine("wait");
            
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void revive()
    {
        if (revived)
        {
            revived = true;

            GameOverPanel.SetActive(false);
            upButton.gameObject.SetActive(true);
            downButton.gameObject.SetActive(true);
            pauseButton.gameObject.SetActive(true);
            scoreText.gameObject.SetActive(true);
            highScoreText.gameObject.SetActive(true);
            player.SetActive(true);
        }
        
    }
}

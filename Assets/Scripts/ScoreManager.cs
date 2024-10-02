using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public Text highScoreText;

    private float score;
    private float highScore;

    private void Start()
    {
        if(PlayerPrefs.HasKey("highScore"))
        {
            highScore = PlayerPrefs.GetFloat("highScore");
        }
    }
    
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            ScoreText.text = ((int)score).ToString();
            highScoreText.text = ((int)highScore).ToString();

            if(score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetFloat("highScore", highScore);
            }
        }
    }
}

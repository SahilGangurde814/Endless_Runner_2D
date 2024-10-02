using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float playerspeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    private float dirY;

    //public GameObject player;

    //public Text scoreText;
    //public Text highScoreText;
    //public Button upButton;
    //public Button downButton;
    //public Button pauseButton;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;

        

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerspeed);
    }

    
    //public void playerDied()
    //{
    //    if (player.activeSelf)
    //    {
    //        // player is alive
    //    }
    //    else
    //    {
    //        upButton.gameObject.SetActive(false);
    //        downButton.gameObject.SetActive(false);
    //        pauseButton.gameObject.SetActive(false);
    //        scoreText.gameObject.SetActive(false);
    //        highScoreText.gameObject.SetActive(false);
    //    }
    //}
}

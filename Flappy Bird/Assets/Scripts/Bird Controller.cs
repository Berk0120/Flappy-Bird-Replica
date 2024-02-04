using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public float jumpForce;

    public Rigidbody2D rb;

    private int score;

    public Text scoreText;

    public GameObject gameOverPanel;


    void Start()
    {
        Time.timeScale = 1;
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Score")
        {
            score++;
            scoreText.text = score.ToString();
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Death")
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            Destroy(gameObject);
        }
    }

  public void restart()
    {
        SceneManager.LoadScene(0);
    }
}

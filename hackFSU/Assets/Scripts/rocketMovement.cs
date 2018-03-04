using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class rocketMovement : MonoBehaviour {

    public float speed = 1;
    public int score = 0;
    public GameObject gameOver;
    public Text userScore;

    void Start()
    {
        gameOver.SetActive(false);
        userScore.text = "Score: " + score;

    }



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            gameOver.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            score++;
            userScore.text = "Score: " + score;
        }
    }

}

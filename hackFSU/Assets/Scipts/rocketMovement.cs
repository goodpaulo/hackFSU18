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


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 2.20)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > -2.20)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

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

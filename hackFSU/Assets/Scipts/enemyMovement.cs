using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 5)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }

    }

}

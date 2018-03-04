using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MoveRight : MonoBehaviour
{

    public float speed = 25;
    public float directionX;
    Rigidbody2D rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    public void Update()
    {
        directionX = CrossPlatformInputManager.GetAxis("Horizontal");
        rb.velocity = new Vector2(directionX * speed, 0);
    }

}

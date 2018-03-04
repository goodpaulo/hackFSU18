using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMovement : MonoBehaviour
{
    Vector2 spawnPos;
    public GameObject Asteroid, UFO;
	// Use this for initialization
	void Start ()
    {
        spawnPos = new Vector2(0, 4);
        InvokeRepeating("ChangePosition", 0, 2);
	}
	
	// Update is called once per frame
	void ChangePosition ()
    {
        transform.position = spawnPos;

        int type = Random.Range(1, 3);

        spawnPos = new Vector2(Random.Range((float)-10.50, (float)10.50), 4);

        if (type == 1)
        {
            Instantiate(Asteroid, spawnPos, Quaternion.identity);
        }

        if (type == 2)
        {
            Instantiate(UFO, spawnPos, Quaternion.identity);
        }
	}
}

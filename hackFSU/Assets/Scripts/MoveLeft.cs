using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {
    public float speed = 1;
	
	// Update is called once per frame
	
        public void Update()
        {
          transform.position += Vector3.left * speed * Time.deltaTime;
        }
    
}

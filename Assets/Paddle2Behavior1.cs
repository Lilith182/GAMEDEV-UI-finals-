using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2Behavior1 : MonoBehaviour
{
    public float speed = 5;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.UpArrow))
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1 * speed);
        }
         if (Input.GetKeyDown (KeyCode.DownArrow))
        {
            this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1 * speed);
        }

    }
}

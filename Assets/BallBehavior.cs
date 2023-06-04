using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public float speed = 5;
    void Start()
    {
        float x = Random.Range (1,2);
        float y = Random.Range (1,2);
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x * speed, y * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

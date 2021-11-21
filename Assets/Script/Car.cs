using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car: MonoBehaviour
{
    public Rigidbody2D rb;

    public float minSpeed = 10f;
    public float maxSpeed = 15f;


    public float speed = 1f;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);


    }
    private void FixedUpdate()
    {
        Vector2 Forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + Forward * Time.fixedDeltaTime * speed);
        
    }
}

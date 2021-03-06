using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class FrogMove : MonoBehaviour
{
    public Rigidbody2D rb;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.down);
        else if (Input.GetKeyDown(KeyCode.UpArrow))
            rb.MovePosition(rb.position + Vector2.left);
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            rb.MovePosition(rb.position + Vector2.right);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "car")
        {
            Debug.Log("YOU DIED");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }


}

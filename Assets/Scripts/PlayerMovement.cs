using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public float speed = 10f;
    Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2 (0, speed);
        if (Input.GetKey(up))
        {
            rb.velocity = move;
        }
        else if (Input.GetKey(down))
        {
            rb.velocity = -move;
        }
        else
        {
            rb.velocity = 0 * move;
        }
        
    }
}

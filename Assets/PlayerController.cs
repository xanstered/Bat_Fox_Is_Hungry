using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpAmount = 8f;
    public float speed;
    private float Move;
    bool facingRight = true;

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jumpAmount);
        }

        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2 (moveInput * speed, rb.velocity.y);

        if(moveInput < 0 && facingRight)
        {
            flip();
        }

        if(moveInput > 0 && !facingRight)
        {
            flip();
        }
    }

    void flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0, 180, 0);
    }
}

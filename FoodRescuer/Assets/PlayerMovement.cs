using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Joystick joystick;
    // Update is called once per frame
    void Start()
    {
        Time.timeScale=1f;
    }
    void Update()
    {
        
        movement.x = joystick.Horizontal;
        // movement.y = joystick.Vertical;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

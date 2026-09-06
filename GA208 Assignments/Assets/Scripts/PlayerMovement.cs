using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private static Vector2 movement;
  
    private Rigidbody2D rb;
    //Establishes the rigidbody variable
    private float speed = 2.5f;
    //Establishes the speed of the Player

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //gets the player's rigidbody component
        rb.gravityScale = 0;
        //sets gravity to zero on rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        //According to the tutorial I followed, Fixed update is not required because the frame rate movment will be the same across all devices, please let me know if this is true or false.
        movement.Set(PlayerControlScript.movement.x,PlayerControlScript.movement.y);
        //Sets the movment variable to the respective movment values in a Vector 2
        rb.linearVelocity = movement * speed;
        //Sends the movement values to the rigidbody2D multiplied by the player speed
    }

        
}

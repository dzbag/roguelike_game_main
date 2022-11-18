using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rbEyes;
    public Rigidbody2D rbReka;
    public Rigidbody2D rb;
    float speed = 5;



    Vector2 movement;




    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        rbEyes.position = rb.position;
        rbReka.position = rb.position;
    }   

}

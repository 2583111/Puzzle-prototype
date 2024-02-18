using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 1f;
    private Vector2 move;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal"); //deals with horizontal/ x movement
    }


    void FixedUpdate()
    {
        //Deals with the movement given by the inputs
        rb.MovePosition(rb.position + move.normalized * moveSpeed * Time.fixedDeltaTime); //"normalized" makes diagonal movement speed the same as vertical and horizontal movement speed

    }

}


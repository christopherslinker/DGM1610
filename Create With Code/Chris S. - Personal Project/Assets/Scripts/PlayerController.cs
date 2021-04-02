﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // my attempt
   /* private float speed = 15f;
    private float horizontalInput;
    private float forwardInput;*/
   
   //tutorials scripts
   private float speed = 10.0f;
   private Rigidbody playerRb;
   private float zBound = 6;
   private float xBound = 15;
   
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        //my attempt
        /*horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);*/

        MovePlayer();
        ConstrainsPlayerPosition();





    }
    
    //moves the player based on arrow key input
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.forward * speed * verticalInput);
        playerRb.AddForce(Vector3.right * speed * horizontalInput);
    }
    
    //Invisible walls
    void ConstrainsPlayerPosition()
    {
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }

        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(transform.position.z, transform.position.y, -xBound);
        }

        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(transform.position.z, transform.position.y, xBound);
        }
    }
}
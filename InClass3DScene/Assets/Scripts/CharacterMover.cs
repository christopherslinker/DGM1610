using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public float speed = 3f, graivty = -8f, jumpForce = 10f;
    private float yDirection;
    public int jumpCountMax = 2;
    private int jumpCount;
    private CharacterController controller;
    private Vector3 movement, rotation;
    public GameObject projectilePrefab;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    { 
        movement.Set(speed*Input.GetAxis("Vertical"), yDirection, 0);
        yDirection += graivty * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yDirection = -1f;
            jumpCount = 0;
        }
        
        if (Input.GetButtonDown("Jump") & jumpCount < jumpCountMax)
        {
            yDirection = jumpForce;
            jumpCount++;
        }

        rotation.y = Input.GetAxis("Horizontal");
        transform.Rotate(rotation);
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}

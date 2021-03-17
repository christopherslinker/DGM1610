using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public float speed = 3f, graivty = -8f, jumpForce = 10f;

    private CharacterController controller;
    private Vector3 movement, rotation;
    public GameObject projectilePrefab;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        movement.Set(speed*Input.GetAxis("Vertical"), graivty, 0);
        rotation.y = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            movement.y = jumpForce;
        }
        
        transform.Rotate(rotation);
        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horsePower = 0;
    //[SerializeField] private float speed = 20.0f;
    [SerializeField] private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] float speed;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] float rpm;
    
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    private void Update()
    {
        speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f);
        speedometerText.SetText("Speed" + speed + "mph");
        rpm = Mathf.Round((speed % 30) * 40);
        rpmText.SetText("RPM" + rpm);
    }

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (IsOnGround())
        {
            //Move the vehicle forward
            //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
            //rotates car
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        }
    }
    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        if (wheelsOnGround == 4)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
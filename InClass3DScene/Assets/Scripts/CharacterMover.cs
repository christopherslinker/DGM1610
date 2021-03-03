using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 movement;
    public float speed = 3f, gravity = -8f;
    private Vector3 yDirection;

    public float jumpForce = 300f;
    void Update()
    {
        {
            movement.y = gravity;
            movement.x = speed * Input.GetAxis("Horizontal");
            movement.z = speed * Input.GetAxis("Vertical");
            controller.Move(movement * Time.deltaTime);
        }

        /*if (Input.GetButtonDown("Jump"))
        {
            yDirection.y = jumpForce;
            BoxCollider.AddForce(yDirection, ForceMode2D.Force);
        }*/
    }
}

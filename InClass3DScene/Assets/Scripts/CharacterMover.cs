using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 movement, rotation;
    public float speed = 100f, gravity = -8f;
    private Vector3 yDirection;
    public GameObject projectilePrefab;
    public float jumpForce = 300f;
    void Update()
    {
        {
            movement.y = gravity;
            movement.x = speed * Input.GetAxis("Horizontal");
            movement.z = speed * Input.GetAxis("Vertical");
            rotation.y = Input.GetAxis("Horizontal");
            transform.Rotate(rotation);
            movement = transform.TransformDirection(movement);
            controller.Move(movement * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        /*if (Input.GetButtonDown("Jump"))
        {
            yDirection.y = jumpForce;
            BoxCollider.AddForce(yDirection, ForceMode2D.Force);
        }*/
    }
}

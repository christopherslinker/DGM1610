using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool gameOver;
    
    private float speed = 25.0f;
   private Rigidbody playerRb;
   private float zBound = 6;

   private PlayerController playerControllerScript;

   public ParticleSystem explosionParticle;
   private GameOverBehaviour gameOverBehaviour;

   private AudioSource playerAudio;
   public AudioClip deathSound;
   
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        playerAudio = GetComponent<AudioSource>();
        
        gameOverBehaviour = GameObject.Find("GameOverBehaviour").GetComponent<GameOverBehaviour>();
    }


    void Update()
    {
        MovePlayer();
        ConstrainsPlayerPosition();
    }
    
    //moves the player based on arrow key input
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (playerControllerScript.gameOver == false)
        {
            playerRb.AddForce(Vector3.forward * speed * verticalInput);
            playerRb.AddForce(Vector3.right * speed * horizontalInput);
        }

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
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            playerAudio.PlayOneShot(deathSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            Destroy(gameObject);
            gameOverBehaviour.GameOver();

            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
        }
    }
}

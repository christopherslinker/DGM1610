using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyBehaviour : MonoBehaviour
{

    private ScoreManager scoreManager;

    private AudioSource moneyAudio;
    public AudioClip collectSound;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        moneyAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            moneyAudio.PlayOneShot(collectSound, 1.0f);
        }
    }


    private void OnDestroy()
    {
        scoreManager.UpdateScore(5);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MoneyBehaviour : MonoBehaviour
{
    private ScoreBehaviour scoreBehaviour;

    public int pointValue;


    private void Start()
    {
        scoreBehaviour = GameObject.Find("Score Behaviour").GetComponent<ScoreBehaviour>();
    }
    
    
}

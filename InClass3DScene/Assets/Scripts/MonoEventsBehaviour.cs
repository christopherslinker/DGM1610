﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent;
    // Start is called before the first frame update
    void Start()
    {
        startEvent.Invoke();
    }

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntData : ScriptableObject
{
    public int value;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetZero()
    {
        value = 0;
    }

    public void Incriment()
    {
        value++;
    }
}
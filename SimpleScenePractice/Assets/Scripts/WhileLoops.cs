using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int cooks = 1;
        while (cooks < 10)
        {
            Debug.Log("We need more cooks.");
            cooks++;
        }

        if (cooks >= 10)
        {
            Debug.Log("Too many cooks!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

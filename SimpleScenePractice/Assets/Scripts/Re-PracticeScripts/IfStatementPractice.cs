using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementPractice : MonoBehaviour


{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

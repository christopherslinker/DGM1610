using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoopArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] avengers = {"Iron-Man", "SpiderMan", "Black Widow", "Scarlet Witch", "Captain America"};
        foreach (string i in avengers)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

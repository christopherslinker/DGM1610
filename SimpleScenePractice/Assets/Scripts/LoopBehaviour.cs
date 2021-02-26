using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBehaviour : MonoBehaviour
{
    public string[] playerNames;

    private IEnumerator start()
    {
        foreach (var playerName in playerNames)
        {
            print(playerName);
        }

        while (true)
        {
            
        }
    }
}

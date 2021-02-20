using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InClassIfStatement : MonoBehaviour

{
    public int a, b, c;
    public string password;
    public bool canEnter;

    public enum GameStates
    {
        Starting, Playing, Ending
    }

    public GameStates currentGameState;

    void Start()
    {
        switch (currentGameState)
        {
            case GameStates.Starting:
                print("Starting");
                break;
            case GameStates.Playing:
                print("Playing");
                break;
            case GameStates.Ending:
                print("Ending");
                break;
        }

        if (a + b == c)
        {
            print(true);
            
        }
        else
        {
            print(false);
        }
        
    }


    void Update()
    {
        
    }
}

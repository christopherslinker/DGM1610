using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{

    public int intellegence = 2;

    void greet()
    {
        switch (intellegence)
        {
            case 2:
                print("Hello there!");
                break;
            case 1:
                print("Uh.... Where am I?");
                break;
        }
    }
}
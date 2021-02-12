using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndOperators : MonoBehaviour
{
    private int cooks = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Time for food.");
        /*
         Module Scripts
        int myInt = 50;
        string myName = "John";
        int x = 5;
        int y = 10;
        int z = x + y;
        int x = 5, y = 10, z = 50;
        Console.WriteLine(x + y + z);
        Console.WriteLine(z);
        Console.WriteLine(x+y);
        Console.WriteLine(myInt);
        Console.WriteLine(myName);
        */

        void CooksInTheKitchen()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                Debug.Log("Time to cook.");
                
                int cooks = 1;

                if (cooks < 5)
                {
                    cooks++;
                    Debug.Log("We need more cooks");
                }

                if (cooks == 5)
                {
                    Debug.Log("Too many cooks.");
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


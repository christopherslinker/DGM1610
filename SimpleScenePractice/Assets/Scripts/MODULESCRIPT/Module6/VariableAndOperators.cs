using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableAndOperators : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
            int cooks = 1;

            if (cooks < 5)
            {
                cooks++;
                Console.WriteLine("We need more cooks");
            }

            if (cooks == 5)
            {
                Console.WriteLine("Too many cooks.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

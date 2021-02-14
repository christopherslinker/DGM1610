using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalsAndSwitches : MonoBehaviour
{

    private int x = 10;

    private int y = 9;
    // Start is called before the first frame update
    void Start()
    {

        if (x > y)
        {
            Console.WriteLine("What month is it?");
        }



        int month = 4;
        switch (month)
        {
            case 1:
                Console.WriteLine("January");
                break;
            case 2:
                Console.WriteLine("Feburary");
                break;
            case 3:
                Console.WriteLine("March");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("May");
                break;
            case 6:
                Console.WriteLine("June");
                break;
            case 7:
                Console.WriteLine("July");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("September");
                break;
            case 10:
                Console.WriteLine("October");
                break;
            case 11:
                Console.WriteLine("November");
                break;
            case 12:
                Console.WriteLine("December");
                break;
            default:
                Console.WriteLine("Time is relative.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

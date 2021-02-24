using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InClassLoops : MonoBehaviour
{
    public int number, total;

    public string[] cars;

    public Weapon weapons;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            total = i;
            print(total);
        }

        foreach (var car in cars)
        {
            print("What is your favorite type of" + car);
        }

        foreach (var weapons in Weapon)
        {
            print("you have a"  + weapons);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

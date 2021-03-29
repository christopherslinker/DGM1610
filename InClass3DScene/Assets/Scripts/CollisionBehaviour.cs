using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            print("triggered");
        }

        if (other.CompareTag("Ammo"))
        {
            print("hit Ammo");
        }

        if (other.CompareTag("Health"))
        {
            print("Health.");
        }
        
    }
    public void PowerUp()
    {
        print("got power up");
    }
    public void Health()
    {
            print("got health");
        }
        public void Ammo()
        {
            print("got Ammo");
    }
    
}

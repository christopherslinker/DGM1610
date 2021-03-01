using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsCollectionBehavior : MonoBehaviour
{
    public Weapon weaponOBJ;

    public WeaponCollection weaponCollectionOBJ;

    private void Start()
    {
        foreach (var weapon in weaponCollectionOBJ.weaponsList)
        {
            if (weapon == weaponOBJ)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        weaponCollectionOBJ.weaponList.Add(weaponOBJ);
        gameObject.SetActive(false);
    }
}

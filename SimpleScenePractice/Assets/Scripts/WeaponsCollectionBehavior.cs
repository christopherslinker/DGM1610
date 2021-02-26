using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsCollectionBehavior : MonoBehaviour
{
    public Weapon weaponOBJ;

    public WeaponCollection WeaopCollectionOBJ;

    private void Start()
    {
        foreach (var weapon in WeaponCollectionOBJ.weapList)
        {
            if (weapon == weaponOBJ)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        WeaponCollectionOBJ.weaponList.Add(weaponOBJ);
        gameObject.SetActive(false);
    }
}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsCollectionBehaviour : MonoBehaviour
{
    public Weapons weaponObj;
    public WeaponCollection weaponCollectionObj;

    private void Start()
    {
        foreach (var weapon in weaponCollectionObj.weaponsList)
        {
            if (weapon == weaponObj)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        weaponCollectionObj.weaponsList.Add(weaponObj);
        gameObject.SetActive(false);
    }
}
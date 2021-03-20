using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPoolBehaviour : MonoBehaviour
{
    public GameObject[] Ammo;
    public int currentAmmoNum;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Ammo[currentAmmoNum].transform.position = transform.position;
            Ammo[currentAmmoNum].transform.rotation = transform.rotation;
            Ammo[currentAmmoNum].SetActive(true);

            if (currentAmmoNum < Ammo.Length-1)
            {
                currentAmmoNum++;
            }
            else
            {
                currentAmmoNum = 0;
            }
        }
    }
}

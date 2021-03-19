using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPoolBehaviour : MonoBehaviour
{
    public GameObject[] Ammo;

    public int currentAmmoNum;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Ammo[currentAmmoNum].SetActive(true);
            Ammo[currentAmmoNum].transform.position = transform.position;
            Ammo[currentAmmoNum].transform.rotation = transform.rotation;
            Ammo[currentAmmoNum].GetComponent<BulletBehaviour>().RunBullet();
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

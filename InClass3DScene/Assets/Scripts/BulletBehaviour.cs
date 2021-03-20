using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletBehaviour : MonoBehaviour
{
    private Rigidbody bulletRB;
    public float bulletForce = 10;
    private Vector3 forces;

    private void Awake()
    {
        bulletRB = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        bulletRB.WakeUp();
        forces.Set(bulletForce, 0, 0);
        bulletForce.AddRelativeForce(forces);
    }

    private void OnDisable()
    {
        bulletRB.Sleep();
    }
}

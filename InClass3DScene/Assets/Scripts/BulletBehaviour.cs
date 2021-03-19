using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletBehaviour : MonoBehaviour
{
    private Rigidbody bulletRB;
    public float bulletForce = 10;
    private Vector3 forces;
    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
        forces.Set(bulletForce, 0, 0);
        bulletRB.velocity += transform.forward * bulletForce;

    }

    public void RunBullet()
    {
        bulletRB = GetComponent<Rigidbody>();
        forces.Set(bulletForce, 0, 0);
        bulletRB.velocity += transform.forward * bulletForce;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

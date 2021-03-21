using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}


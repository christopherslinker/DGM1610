using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateBehaviour : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        gameObject.SetActive(false);
    }

    private IEnumerator Start()
    {
        yield return new WaitForSeconds(2);
        gameObject.SetActive(false);
    }
}

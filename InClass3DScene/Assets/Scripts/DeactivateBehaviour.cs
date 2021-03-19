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
}

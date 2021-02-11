using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDown : MonoBehaviour
{
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}

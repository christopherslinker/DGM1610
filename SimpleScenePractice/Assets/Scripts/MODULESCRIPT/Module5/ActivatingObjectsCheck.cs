using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatingObjectsCheck : MonoBehaviour
{

    public GameObject myObject;
    void Start()
    {
        Debug.Log("Active Self" + myObject.activeSelf);
        Debug.Log("Active In Hierarchy" + myObject.activeInHierarchy);
    }

}

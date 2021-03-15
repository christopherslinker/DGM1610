using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, 6);
    
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}

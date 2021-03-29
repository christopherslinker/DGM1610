﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
[RequireComponent(typeof(NavMeshAgent))]
public class AgentBehaviour : MonoBehaviour
{
    public List<Transform> wayPoints;
    private Transform destination;
    private NavMeshAgent agent;
    private int i;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = wayPoints[i];
    }


    void Update()
    {
        agent.destination = destination.position;
       if (!agent.pathPending && agent.remainingDistance < 0.5f)
       {
           i = (i + 1) % wayPoints.Count;
               destination = wayPoints[i];
       }
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = transform;
        print(other.name);
    }

    private void OnTriggerExit(Collider other)
    {
        destination = wayPoints[i];
    }
}

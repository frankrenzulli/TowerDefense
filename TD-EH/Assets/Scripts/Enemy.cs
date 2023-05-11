using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    NavMeshAgent agent;

    public Transform[] Waypoints;
    int waypointsIndex = 0;
    Vector3 target;
    //public float speed = 5f; // Velocità dell'oggetto
    //public Vector3 direction; // Direzione di movimento dell'oggetto

    private void Start()
    {
        agent = GetComponentInChildren<NavMeshAgent>();
        UpdateDestination();
    }
    private void Update()
    {
        if(Vector3.Distance(transform.position, target) < 0.25f)
        {
            Debug.Log("dio");
            IterateWaypointsIndex();
            UpdateDestination();
            
        }
        
        //direction = new Vector3(1, 0, 0);
        // Muovi l'oggetto nella direzione specificata alla velocità specificata
        //transform.position += direction * speed * Time.deltaTime;
    }

    void UpdateDestination()
    {
        target = Waypoints[waypointsIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointsIndex()
    {
        waypointsIndex++;
        
    }
}


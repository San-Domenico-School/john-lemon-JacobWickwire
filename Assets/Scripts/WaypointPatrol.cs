/* this script is attached to the move the Ghosts between an assigned groups of waypoints.  
 * Jacob Wickwire
 * 6/4/2024 
 */

using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointPatrol : MonoBehaviour
{
    [SerializeField] NavMeshAgent navMeshAgent;
    [SerializeField] Transform[] waypoints;
    int currentWaypointIndex;


    // Sets the initial destination of the Ghost
    void Start()
    {
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    // Moves the Ghosts between destinations
    void Update()
    {
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[currentWaypointIndex].position);
        }
    }

}

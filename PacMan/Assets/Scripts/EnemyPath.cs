using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPath : MonoBehaviour
{

    public Transform[] waypoints; // Assign in Inspector
    public float speed = 2f;
    private int currentWaypointIndex = 0;
    void Start()
    {
        
    }

    void Update()
    {
        if (waypoints.Length == 0) return;

        // Move toward the current waypoint
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, speed * Time.deltaTime);

        // Check if we reached the waypoint
        if (Vector2.Distance(transform.position, waypoints[currentWaypointIndex].position) < 0.1f)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length; // Loop back
        }
    }

}

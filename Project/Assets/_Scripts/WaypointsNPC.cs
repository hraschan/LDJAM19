using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointsNPC : MonoBehaviour
{
    [SerializeField]
    private GameObject[] waypoints;
    int current = 0;
    float rotSpeed;
    [SerializeField]
    private float speed;
    [SerializeField]
    float WPradius = 1;

    // Update is called once per frame
    void Update()
    {
        if (!Global.enemy)
        {

        }
}
    void waypoint()
    {
        if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current++;
            if (current >= waypoints.Length)
            {
                current = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
    }
}

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
    [SerializeField]
    float abstand =1;
    Vector3 lookDirection;

    private GameObject player;
    // Update is called once per frame
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
            }
    void Update()
    {
        
        if (!Global.enemy)
        {
            waypoint();
        }
        else
        {
            followPlayer();
            //Debug.Log("followMEEE");
            
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
    void followPlayer()
    {
        lookDirection = (player.transform.position - transform.position).normalized;
        //transform.LookAt(player.transform);
        if((transform.position - player.transform.position).magnitude > abstand)
        {
            transform.Translate(lookDirection * Time.deltaTime * speed);
        }
        
    }
}

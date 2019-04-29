using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrankensteinController : MonoBehaviour
{

    private int speedLimit = 3;

    private float moveSpeed = 150;
    private Rigidbody r;

    // Use this for initialization
    void Start()
    {
        r = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Moves Forward and back along z axis                           //Up/Down 
        //transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);
        float x = Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed;
        float z = Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed;

        x = Mathf.Clamp(x, -speedLimit, speedLimit);
        z = Mathf.Clamp(z, -speedLimit, speedLimit);


        Debug.Log(x + " " + z);

        r.velocity = new Vector3(x, 0, z);

        //Moves Left and right along x Axis                               //Left/Right
        //transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);


        //this.GetComponent<Rigidbody>().AddForce(x, 0, z);

        //Vector3 speed = r.velocity;
        //float newX = Mathf.Clamp(speed.x, -speedLimit, speedLimit);
        //float newZ = Mathf.Clamp(speed.z, -speedLimit, speedLimit);



    }
}

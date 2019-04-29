using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrankensteinController : MonoBehaviour
{
    [SerializeField]
    int speedLimit;

    public float moveSpeed;
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
        if (Input.GetAxis("Horizontal") == 0) r.velocity = new Vector3(0, 0, r.velocity.z);
        float z = Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed;
        if (Input.GetAxis("Vertical") == 0) r.velocity = new Vector3(r.velocity.x, 0, 0);

        Debug.Log(x + " " + z);

        Vector3 speed = r.velocity;
        float newX = Mathf.Clamp(speed.x, -speedLimit, speedLimit);
        float newZ = Mathf.Clamp(speed.z, -speedLimit, speedLimit);

        r.velocity = new Vector3(newX, 0, newZ);

        this.GetComponent<Rigidbody>().AddForce(x, 0, z);


        //Moves Left and right along x Axis                               //Left/Right
        //transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);


       
    }
}

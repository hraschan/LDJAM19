using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    //Objects
    public GameObject object1 = GameObject.Find("Sphere");
    public GameObject object2;
    public GameObject object3;

    //Collider
    public Collider[] colliders;
    public float raduis;
    //Positions
    private float spawnPositionX;
    private float spawnPositionZ;
    private float spawnPositionX1;
    private float spawnPositionZ1;
    private float spawnPositionX2;
    private float spawnPositionZ2;

    // Start is called before the first frame update

    private void Start()
    {
        spawnItem();

    }
    public void spawnItem() {

        spawnPositionX = Random.Range(Global.negativemaxX, Global.positivemaxX);
        spawnPositionZ = Random.Range(Global.negativemaxZ, Global.positivemaxZ);
        Vector3 spawnPos = new Vector3(spawnPositionX, 0.59f, spawnPositionZ);

        object1.transform.position = spawnPos;

    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

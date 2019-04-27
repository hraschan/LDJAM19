using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    private float spawnPositionX;
    private float spawnPositionZ;

    // Start is called before the first frame update
    void Start()
    {
        spawnPositionX = Random.Range(Global.negativemaxX, Global.positivemaxX);
        spawnPositionZ = Random.Range(Global.negativemaxZ, Global.positivemaxZ);
        object1.transform.position = new Vector3(spawnPositionX, 0.59f, spawnPositionZ);
        object2.transform.position = new Vector3(spawnPositionX, 0.59f, spawnPositionZ);
        object3.transform.position = new Vector3(spawnPositionX, 0.59f, spawnPositionZ);




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

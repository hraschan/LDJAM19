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

        bool canSpawnhere;
        spawnPositionX = Random.Range(Global.negativemaxX, Global.positivemaxX);
        spawnPositionZ = Random.Range(Global.negativemaxZ, Global.positivemaxZ);
        Vector3 spawnPos = new Vector3(spawnPositionX, 0.59f, spawnPositionZ);
        canSpawnhere = preventSpawnOverlap(spawnPos);
        object1.transform.position = spawnPos;

    }
    void preventSpawnOverlap(Vector3 spawnPos)
    {
        colliders = Physics.OverlapSphere(transform.position, raduis);

        for(int i = 0; i < colliders.Length; i++)
        {
            Vector3 centerPoint = colliders[i].bounds.center;
            float width = colliders[i].bounds.extents.x;
            float length = colliders[i].bounds.extents.z;

            float leftExtent = centerPoint.x - width;
            float rightExtent = centerPoint.x + width;
            float lowerExtent = centerPoint.z - length;
            float upperExtent = centerPoint.z + length;

            if (spawnPos.x >= leftExtent && spawnPos.x <= rightExtent)
            {
                if(spawnPos.z >= lowerExtent && spawnPos.z <= upperExtent)
                {
                    return false;
                }
            }
            return true ;
        }
    }
    





    // Update is called once per frame
    void Update()
    {
        
    }
}

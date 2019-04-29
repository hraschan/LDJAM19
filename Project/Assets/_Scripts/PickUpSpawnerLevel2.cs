using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PickUpSpawnerLevel2 : MonoBehaviour
{
    //Objects
    [SerializeField]
    private Object[] originals = new GameObject[7];
    [SerializeField]
    private GameObject original;

    //Collider
    public Collider[] colliders;
    public float raduis;
    //Positions
    private float spawnPositionX;
    private float spawnPositionZ;

    Vector3 spawnPos;
    // Start is called before the first frame update
    //string midPath = "/Prefab";
    // Use this for initialization
    void Start()
    {
        //originals = Resources.LoadAll(midPath, typeof(GameObject[])) as GameObject[];
        //original = new GameObject();

        spawnItem();
        preventSpawnOverlap();
    }

    public void spawnItem()
    {
        //int a = Random.Range(0,7); //NullReferenceException here
        // original = originals[1] as GameObject;
        //Debug.Log("Name" + originals[0]);


        bool canSpawnhere = false; ;
        int safetyNet = 0;


        while (!canSpawnhere)
        {
            spawnPositionX = Random.Range(Global.negativemaxX, Global.positivemaxX);
            spawnPositionZ = Random.Range(Global.negativemaxZ, Global.positivemaxZ);
            spawnPos = new Vector3(spawnPositionX, 1.37f, spawnPositionZ);
            canSpawnhere = preventSpawnOverlap();


            if (canSpawnhere == true)
            {
                break;
            }
            safetyNet++;
            if (safetyNet > 50)
            {
                break;
                // Debug.Log("To many attemts");
            }
        }
        Debug.Log("Position: " + spawnPos);
        original.transform.position = spawnPos;
        // original.transform.localScale = new Vector3(100, 100, 100);

    }
    bool preventSpawnOverlap()
    {
        colliders = Physics.OverlapSphere(transform.position, raduis);


        for (int i = 0; i < colliders.Length; i++)
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

                if (spawnPos.z >= lowerExtent && spawnPos.z <= upperExtent)
                {
                    return false;
                }
            }
            return true;
        }
        return false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlayerSpawn : MonoBehaviour
{

    public GameObject player;
    private float positionX;
    private float positionZ;

    /*
    [SerializeField]
    private float negativemaxX;
    [SerializeField]
    private float positivemaxX;
    [SerializeField]
    private float negativemaxZ;
    [SerializeField]
    private float positivemaxZ;
    */


    // Start is called before the first frame update
    void Start()
    {
        positionX = Random.Range(Global.negativemaxX, Global.positivemaxX);
        positionZ = Random.Range(Global.negativemaxZ, Global.positivemaxZ);
        player.transform.position = new Vector3(positionX, 0.59f, positionZ);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

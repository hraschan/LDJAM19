using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlayerSpawn : MonoBehaviour
{
    public GameObject player;
    private float positionX;
    private float positionY;
    [SerializeField]
    private float negativemaxX;
    [SerializeField]
    private float positivemaxX;
    [SerializeField]
    private float negativemaxZ;
    [SerializeField]
    private float positivemaxZ;



    // Start is called before the first frame update
    void Start()
    {
        positionX = Random.Range(negativemaxX, positivemaxX);
        positionY = Random.Range(negativemaxZ, positivemaxZ);
        player.transform.position = new Vector3(positionX, 0.59f, positionY);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpQuestionScript : MonoBehaviour
{
    public GameObject player;
    public GameObject humanbody;

    Vector3 playerPosition;
    Vector3 humanbodyPosition;

    int range = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(playerPosition, humanbodyPosition) < range)
        {
            Debug.Log("In der Nähe!");
        }
    }
}

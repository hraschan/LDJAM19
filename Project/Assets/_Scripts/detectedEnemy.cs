using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectedEnemy : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
    
        if(other.gameObject.tag == "player")
        {
            //Globaler Bool auf true - Danach wird followPlayer ausgeführt.
            Debug.Log("Player Detected");
            Global.enemy = true;
        }
    }
}

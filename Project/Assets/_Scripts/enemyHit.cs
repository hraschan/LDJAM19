using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHit : MonoBehaviour
{
    private GameObject player;
    float time = 1;

    private void Start()
    {
        StartCoroutine(MyFunction(time));
    }

    private void OnTriggerEnters (Collider other)
    {
        //if (other.gameObject.tag == "player")
            //Debug.Log("chrash");
            Global.cur_health = Global.cur_health - 20f;
            //MyFunction(time);
            
        
    }
    IEnumerator MyFunction(float Time)
    {
        yield return new WaitForSeconds(time);

    }
   }

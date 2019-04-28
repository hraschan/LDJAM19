using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHit : MonoBehaviour
{
    private GameObject player;
    float time = 1;
    bool fire = false;
    private void Start()
    {
        //StartCoroutine(MyFunction(time));
    }

    private void Update()
    {
        if (fire)
        {
            Global.cur_health = Global.cur_health - 20f;

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //fire = true;
        if (other.gameObject.tag == "player")
        {
            Global.cur_health = -20f;
            Debug.Log("chrash");
        }
        // Global.cur_health = -20f;
        //MyFunction(time);

    }
    //private void OnTriggerExit(Collider other)
   


    IEnumerator MyFunction(float Time)
    {
        yield return new WaitForSeconds(time);

    }
   }

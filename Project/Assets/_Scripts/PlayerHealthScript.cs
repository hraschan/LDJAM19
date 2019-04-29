using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public float max_Health = 100f;
   // public float cur_Health = 0f;

    float curTime = 0;
    float nextDamage = 1;

    public GameObject healthBar;
    // Start is called before the first frame update
    void Start()
    {
        Global.cur_Health = max_Health;
        InvokeRepeating("decreasehealth", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void decreasehealth()
    {
        Global.cur_Health -= 2f;
        float calc_Health = Global.cur_Health / max_Health;
        SetHealthBar(calc_Health);
    }

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f),
                                                     healthBar.transform.localScale.y,
                                                     healthBar.transform.localScale.z);
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "enemy")
        {
            if (curTime <= 0)
            {
            Global.cur_Health = Global.cur_Health -10f;
            Debug.Log("krach");
                curTime = nextDamage;
            }
            else
            {

                curTime -= Time.deltaTime;
            }
        }
    }
}

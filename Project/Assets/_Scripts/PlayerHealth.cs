using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Image Bar;
    //public GameObject healthBar;

    // Start is called before the first frame update
    void Start()
    {
        Global.cur_health = Global.max_health;
        InvokeRepeating("decreasehealth", 0f,2f);
    }
    void decreasehealth()
    {
        //Global.cur_health -= 5f;
        float calc_Health = Global.cur_health  / Global.max_health; // Wenn cur_health 80 ist und max_health 100, kommt scale 0.8 für die bar raus
        //Debug.Log(calc_Health);
        if(calc_Health >= 0)
        {
            SetHealthBar(calc_Health);
        }
       
    }

    public void SetHealthBar(float myHealth)
    {
        Bar.fillAmount = myHealth;
        //healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}

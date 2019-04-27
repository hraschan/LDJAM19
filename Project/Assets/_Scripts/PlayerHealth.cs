using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float max_health = 100f;
    public float cur_health = 0f;
    public GameObject healthBar;

    // Start is called before the first frame update
    void Start()
    {
        cur_health = max_health;
        InvokeRepeating("decreasehealth", 1f,1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void decreasehealth()
    {
        cur_health -= 5f;
        float calc_Health = cur_health / max_health; // Wenn cur_health 80 ist und max_health 100, kommt scale 0.8 für die bar raus
        SetHealthBar(calc_Health);
    }

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}

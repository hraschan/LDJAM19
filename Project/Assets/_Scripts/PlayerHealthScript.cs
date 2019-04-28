using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{
    public float max_Health = 100f;
    public float cur_Health = 0f;

    public GameObject healthBar;
    // Start is called before the first frame update
    void Start()
    {
        cur_Health = max_Health;
        InvokeRepeating("decreasehealth", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void decreasehealth()
    {
        cur_Health -= 5f;
        float calc_Health = cur_Health / max_Health;
        SetHealthBar(calc_Health);
    }

    public void SetHealthBar(float myHealth)
    {
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(myHealth, 0f, 1f),
                                                     healthBar.transform.localScale.y,
                                                     healthBar.transform.localScale.z);
    }
}

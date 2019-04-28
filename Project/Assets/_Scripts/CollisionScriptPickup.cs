using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionScriptPickup : MonoBehaviour
{
    public Text aufhebentext;
    public Button essenbutton;
    public Button ignorierenbutton;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hallow");
            aufhebentext.gameObject.SetActive(true);
            essenbutton.gameObject.SetActive(true);
            ignorierenbutton.gameObject.SetActive(true);

        }
    }
    
        
    
}

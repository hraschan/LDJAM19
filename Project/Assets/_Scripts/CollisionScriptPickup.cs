using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionScriptPickup : MonoBehaviour
{
    public Text aufhebentext;
    public Button essenbutton;
    public Button ignorierenbutton;
    private string[] pickupNames= new string[7];

    void findPickup()
    {
        pickupNames[0] = "arm";
        pickupNames[1] = "körper";
        pickupNames[2] = "auge";
        pickupNames[3] = "perrücke";
        pickupNames[4] = "schraube";
        pickupNames[5] = "bein";
        pickupNames[6] = "kopf";
        aufhebentext.gameObject.SetActive(true);
        essenbutton.gameObject.SetActive(true);
        ignorierenbutton.gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "arm")
        {
            Debug.Log("Hallow");
            findPickup();
            Destroy(GameObject.FindGameObjectWithTag("arm"));

        }
        else
        {

        }
        if (other.gameObject.tag == "körper")
        {
            Debug.Log("Hallow");
            findPickup();
            Destroy(GameObject.FindGameObjectWithTag("körper"));

        }
        else
        {

        }
        if (other.gameObject.tag == "auge")
        {
            Debug.Log("Hallow");
            findPickup();
            Destroy(GameObject.FindGameObjectWithTag("auge"));

        }
        else
        {

        }
        if (other.gameObject.tag == "perrücke")
        {
            Debug.Log("Hallow");
            findPickup();
            Destroy(GameObject.FindGameObjectWithTag("perrücke"));

        }
        else
        {

        }
        if (other.gameObject.tag == "schraube")
        {
            Debug.Log("Hallow");
            findPickup();
            Destroy(GameObject.FindGameObjectWithTag("schraube"));

        }
        else
        {

        }
        if (other.gameObject.tag == "bein")
        {
            Debug.Log("Hallow");
            findPickup();
            Destroy(GameObject.FindGameObjectWithTag("bein"));

        }
        else
        {

        }
        if (other.gameObject.tag == "kopf")
        {
            Debug.Log("Hallow");
            findPickup();
            Destroy(GameObject.FindGameObjectWithTag("kopf"));

        }
        else
        {

        }

    }
    
        
    
}

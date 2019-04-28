﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollisionScriptPickup : MonoBehaviour
{
    public Text aufhebentext;
    public Button essenbutton;
    public Button ignorierenbutton;
    private string[] pickupNames= new string[7];
    GameObject körper;
    

        private void Start()
    {
    }
    public void activeText()
    {

        aufhebentext.gameObject.SetActive(true);
        essenbutton.gameObject.SetActive(true);
        ignorierenbutton.gameObject.SetActive(true);

    }
    public void deactiveText()
    {
        aufhebentext.gameObject.SetActive(false);
        essenbutton.gameObject.SetActive(false);
        ignorierenbutton.gameObject.SetActive(false);
    }
    public void essen()

    {
       
        if(Global.TagName == "körper")
        {
            
            Destroy(GameObject.FindGameObjectWithTag("körper"));
        }
        switch (Global.TagName)
        {
            case "arm":
                Destroy(GameObject.FindGameObjectWithTag("arm"));
                deactiveText();
                break;
            case "körper":
                Destroy(GameObject.FindGameObjectWithTag("körper"));
                deactiveText();
                break;
            case "bein":
                Destroy(GameObject.FindGameObjectWithTag("bein"));
                deactiveText();
                break;
            case "perrücke":
                Destroy(GameObject.FindGameObjectWithTag("perrücke"));
                deactiveText();
                break;
            case "schraube":
                Destroy(GameObject.FindGameObjectWithTag("schraube"));
                deactiveText();
                break;
            case "kopf":
                Destroy(GameObject.FindGameObjectWithTag("kopf"));
                deactiveText();
                break;
            case "auge":
                Destroy(GameObject.FindGameObjectWithTag("auge"));
                deactiveText();
                break;


        }
        

    }
    public void behalten()

    {

        if (Global.TagName == "körper")
        {

            Destroy(GameObject.FindGameObjectWithTag("körper"));
        }
        switch (Global.TagName)
        {
            case "arm":
                Global.arm = true;
                deactiveText();
                break;
            case "körper":
                Global.körper = true;
                deactiveText();
                break;
            case "bein":
                Global.bein = true; deactiveText();
                break;
            case "perrücke":
                Global.perrücke = true; deactiveText();
                break;
            case "schraube":
                Global.schraube = true; deactiveText();
                break;
            case "kopf":
                Global.kopf = true; deactiveText();
                break;
            case "auge":
                Global.auge = true; deactiveText();
                break;


        }


    }
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "arm")
        {
            Global.TagName = "arm";
            Debug.Log("Hallow");
            //Destroy(GameObject.FindGameObjectWithTag("arm"));
            activeText();
            

        }else

        if (other.gameObject.tag == "körper")
        {
            Global.TagName = "körper";
            Debug.Log(Global.TagName);
            activeText();
            //Destroy(GameObject.FindWithTag("körper"));
            
           

        }else

        if (other.gameObject.tag == "auge")
        {
            Global.TagName = "auge";
            Debug.Log("Hallow");
            activeText();
            //Destroy(GameObject.FindGameObjectWithTag("auge"));

        }
        else

        if (other.gameObject.tag == "perrücke")
        {
            Global.TagName = "perrücke";
            Debug.Log("Hallow");
            activeText();
           // Destroy(GameObject.FindGameObjectWithTag("perrücke"));

        }else

        if (other.gameObject.tag == "schraube")
        {
            Global.TagName = "schraube";
            Debug.Log("Hallow");
            activeText();
            Destroy(GameObject.FindGameObjectWithTag("schraube"));

        }
        else

        if (other.gameObject.tag == "bein")
        {
            Global.TagName = "bein";
            Debug.Log("Hallow");
            activeText();
            

        }
        else

        if (other.gameObject.tag == "kopf")
        {
            Global.TagName = "kopf";
            Debug.Log("Hallow");
            activeText();

        }
   

    }
    
        
    
}

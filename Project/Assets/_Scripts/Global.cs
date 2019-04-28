using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global
{
    //Hier werden Globale Variablen gespeichert

    // Variablen für die größe der Welt (In diesem Bereich können Objecte Spawnen
    public static float negativemaxX = -4.05F;
    public static float positivemaxX = 21.05f;
    public static float negativemaxZ = -1.62f;
    public static float positivemaxZ = 10.74f;

    //Bool ob gegner gesehen wurde oder nicht
    public static bool enemy = false;

    //Healthbar
    public static float max_health = 100f;
    public static float cur_health = 0f;
    public static float mult_health = 0f;


    //Bool Feuer hat getroffen oder nicht
    public static bool hit = false;

    public static  string TagName = "Nicht befüllt";

    public static bool körper = false;
    public static bool perrücke = false;
    public static bool kopf = false;
    public static bool bein = false;
    public static bool schraube = false;
    public static bool arm = false;
    public static bool auge = false;
}

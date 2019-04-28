using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global
{
    //Hier werden Globale Variablen gespeichert

    // Variablen für die größe der Welt (In diesem Bereich können Objecte Spawnen
    public static float negativemaxX = -9.5f;
    public static float positivemaxX = 9.53f;
    public static float negativemaxZ = -9.5f;
    public static float positivemaxZ = 9.5f;

    //Bool ob gegner gesehen wurde oder nicht
    public static bool enemy = false;

    //Healthbar
    public static float max_health = 100f;
    public static float cur_health = 0f;
    public static float mult_health = 0f;

    //Bool Feuer hat getroffen oder nicht
    public static bool hit = false;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clasa2 : MonoBehaviour
{
    public int var1 = 5;
    public static int var2 = 2;

    public void MetodaMea()
    {
        int rezultat = var1 + var2;
        Debug.Log("MyRez: " + rezultat);
    }

    public static void MetodaStat()
    {
        int var3 = 15;
        int rez = var2 + var3;
        Debug.Log("Rezultat static: " + rez);
    }
}

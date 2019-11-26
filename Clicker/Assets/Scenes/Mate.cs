using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mate : MonoBehaviour
{
    int myVar = 10;
    Clasa2 myClass = new Clasa2();

    private void Awake()
    {
        Clasa2.var2 = 30;
        myClass.var1 = 20;
    }

    // Start is called before the first frame update
    void Start()
    {
        int rez = myVar + myClass.var1;
        Debug.Log("Rezultat 1: " + rez + " pe obiectul " + gameObject.name);
        //myClass.MetodaMea();

        rez = myVar + Clasa2.var2;
        Debug.Log("Rezultat 2: " + rez + " pe obiectul " + gameObject.name);
        //Clasa2.MetodaStat();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

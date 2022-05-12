using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Goma : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2;
    }

    void Update()
    {
        //Bloque irrompible
        if (resistencia <= 1)
        {
            resistencia++;
        }
    }

}

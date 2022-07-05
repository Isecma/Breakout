using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Vidrio : Bloque
{
    //Bloque el doble de largo
    // Start is called before the first frame update
    void Start()
    {
        if (opcionesSO.NivelDificultad == Opciones.dificultad.easy)
        {
            resistencia = 2;
        }
        else if (opcionesSO.NivelDificultad == Opciones.dificultad.normal)
        {
            resistencia = 4;
        }
        else if (opcionesSO.NivelDificultad == Opciones.dificultad.hard)
        {
            resistencia = 6;
        }
    }
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}

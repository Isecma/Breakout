using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Madera : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        if (opcionesSO.NivelDificultad == Opciones.dificultad.easy)
        {
            resistencia = 3;
        }
        else if (opcionesSO.NivelDificultad == Opciones.dificultad.normal)
        {
            resistencia = 6;
        }
        else if (opcionesSO.NivelDificultad == Opciones.dificultad.hard)
        {
            resistencia = 9;
        }
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}

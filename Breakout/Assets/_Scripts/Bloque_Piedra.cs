using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Piedra : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        if (opcionesSO.NivelDificultad == Opciones.dificultad.easy)
        {
            resistencia = 5;
        }
        else if (opcionesSO.NivelDificultad == Opciones.dificultad.normal)
        {
            resistencia = 7;
        }
        else if (opcionesSO.NivelDificultad == Opciones.dificultad.hard)
        {
            resistencia = 10;
        }
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}

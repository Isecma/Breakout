using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestraSuscriptor : MonoBehaviour
{
    MuestraEventos suscriptor;
    // Start is called before the first frame update
    void Start()
    {
        suscriptor = GetComponent<MuestraEventos>();
        suscriptor.EnCasoDeEspacioPresionado += MensajeEscuchadoPorElSuscriptor;
    }

    private void MensajeEscuchadoPorElSuscriptor(object sender, EventArgs e)
    {
        Debug.Log("El evento ha sido escuchado desde otra clase");
        suscriptor.EnCasoDeEspacioPresionado -= MensajeEscuchadoPorElSuscriptor;
    }
}

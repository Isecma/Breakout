using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public int resistencia;
    public UnityEvent AumentarPuntaje;
    public Opciones opcionesSO;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion =  collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.gameObject.GetComponent<Bola>().velocidadBola++;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;

        resistencia--;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        if (opcionesSO.NivelDificultad == Opciones.dificultad.easy)
        {
            resistencia = 1;
        }
        else if (opcionesSO.NivelDificultad == Opciones.dificultad.normal)
        {
            resistencia = 2;
        }
        else if (opcionesSO.NivelDificultad == Opciones.dificultad.hard)
        {
            resistencia = 3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }   
    }

  
}

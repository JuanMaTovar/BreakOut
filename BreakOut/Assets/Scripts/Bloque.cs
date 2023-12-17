using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    // Start is called before the first frame update
    public int resistencia = 1;
    public UnityEvent AumentarPuntaje;
    public Opciones opciones;
   
    

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        resistencia--;
    }

    void Start()
    {

        if (opciones.NivelDificultad == Opciones.Dificultad.normal)
        {
            resistencia *= 1;
        }
        else if (opciones.NivelDificultad == Opciones.Dificultad.normal)
        {
            resistencia *= 2;
        }
        else if (opciones.NivelDificultad == Opciones.Dificultad.normal)
        {
            resistencia *= 3;
        }

    }

    // Update is called once per frame
    void Update()
    {
       
        if (resistencia <= 0)
        {
            Destroy(this.gameObject);
        }
       



    }

    //la palabra virtual nos va a permitir hacer sobrecarga de el método RebotarBola()
    public virtual void RebotarBola()
    {

    }
}

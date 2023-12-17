using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Goma : Bloque
{
    public int rebote = 2;
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 5;
    }

    // Update is called once per frame
    //Con override estamos indicando que hacemos la sobrecarga del método RebotarBola()
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision); //es el método base de la clase Bloque de la cual estamos heredando
    }
}

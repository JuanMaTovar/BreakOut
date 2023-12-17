using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Metal : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 6;
    }

    //Con override estamos indicando que hacemos la sobrecarga del m�todo RebotarBola()
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision); //es el m�todo base de la clase Bloque de la cual estamos heredando
    }
}

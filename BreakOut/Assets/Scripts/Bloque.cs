using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    // Start is called before the first frame update
    public int resistencia = 1;
    void Start()
    {
        
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

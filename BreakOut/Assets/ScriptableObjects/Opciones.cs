using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Opciones", menuName = "Herramientas/Opciones", order = 1)]

public class Opciones : PuntajePersistente
{
    public float velocidadBola = 30;
    public Dificultad NivelDificultad = Dificultad.facil;

    public enum Dificultad
    {
        facil,
        normal,
        dificil
    }
    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola = nuevaVelocidad;
    }
    public void CambiarDificultad(int nuevaDificultad)
    {
        NivelDificultad = (Dificultad)nuevaDificultad;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

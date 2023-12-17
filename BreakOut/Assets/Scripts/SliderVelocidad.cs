using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderVelocidad : MonoBehaviour
{
    public Opciones opciones;
    Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = this.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { ControlCambios(); });
    }

    public void ControlCambios()
    {
        opciones.CambiarVelocidad(slider.value);
    }

   
}

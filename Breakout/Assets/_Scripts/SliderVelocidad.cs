using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderVelocidad : MonoBehaviour
{
    public Opciones opciones;
    public TMP_Text tagVelocidad;

    Slider slider;

    public void Start()
    {
        slider = this.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { ControlarCambios(); });
        
    }
    public void Update()
    {
        tagVelocidad.text = $"Ball's velocity: {slider.value}";
    }

    public void ControlarCambios()
    {
        opciones.CambiarVelocidad(slider.value);
    }
}

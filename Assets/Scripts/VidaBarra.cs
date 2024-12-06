using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class VidaBarra : MonoBehaviour
{
    Slider _slider;
    void Start()
    {
        _slider = GetComponent<Slider>();
    }
    void Update()
    {
        
    }
    public void CambiarVidaMaxima(float vidaMaxima)
    {
        _slider.maxValue = vidaMaxima;
    }
    public void CambiarVidaActual(float vidaActual)
    {
        _slider.value = vidaActual;
    }
    public void StartVidaBarra(float vidaActual)
    {
        CambiarVidaMaxima(vidaActual);
        CambiarVidaActual(vidaActual);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; 

public class menuopciones : MonoBehaviour
{
    [SerializeField] private AudioMixer AudioMixer;

    public void PantallaCompleta(bool PantallaCompleta)
    {
        Screen.fullScreen = PantallaCompleta;
    }
    
    public void CambiarVolumen(float volumen)
    {
        AudioMixer.SetFloat("Volumen", volumen);
    }

    public void CambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}

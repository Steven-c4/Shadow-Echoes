using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManePausa : MonoBehaviour
{
    [SerializeField] private GameObject barraDeVida;
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    public void Pausa()
    {
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
        barraDeVida.SetActive(false); // Oculta la barra de vida cuando se pausa.
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
        barraDeVida.SetActive(true); // Muestra la barra de vida cuando se reanuda.
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeQuedaDuro : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float tiempoDesaparicion; // Tiempo para desaparecer después de la muerte

    private Animator animator;
    private bool isMuerto = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TomarDaño(float daño)
    {
        if (!isMuerto)
        {
            vida -= daño;

            if (vida <= 0)
            {
                Muerte();
            }
        }
    }

    private void Muerte()
    {
        isMuerto = true;
        animator.SetTrigger("Muerte");

        // Invoca la función Desaparecer después del tiempo de desaparición
        Invoke("Desaparecer", tiempoDesaparicion);
    }

    private void Desaparecer()
    {
        // Aquí puedes realizar cualquier acción para desactivar o destruir el enemigo
        gameObject.SetActive(false); // O puedes usar Destroy(gameObject) si prefieres destruirlo
    }
}

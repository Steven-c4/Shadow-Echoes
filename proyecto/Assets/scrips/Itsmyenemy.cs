using UnityEngine;

public class EnemigoControl : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Añade una función para recibir daño
    public void RecibirDanio(int cantidadDanio)
    {
        // Realiza acciones para recibir daño, como reproducir animación de recibir daño.
        anim.SetTrigger("RecibirDanio"); // Activa la animación de recibir daño en el Animator.
    }
}

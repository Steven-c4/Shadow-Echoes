using UnityEngine;

public class ViejoHealth : MonoBehaviour
{
    public float vida; // Variable de vida accesible desde otros scripts
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TomarDaño(float daño)
    {
        vida -= daño;

        if (vida <= 0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        animator.SetTrigger("Medieronunvergazo");
        // Aquí puedes agregar código adicional para manejar la muerte de Viejo, como reiniciar el nivel o mostrar un mensaje de fin de juego.
    }
}

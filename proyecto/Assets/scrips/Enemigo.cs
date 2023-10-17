using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float vida; // Variable de vida accesible desde otros scripts
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private bool desvanecer = false;
    private float tiempoDesvanecer = 1.0f; // Controla la velocidad de desvanecimiento

    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        animator.SetTrigger("Muerte");
        desvanecer = true;
        Destroy(gameObject, tiempoDesvanecer); // Destruir el enemigo después de cierto tiempo
    }

    private void Update()
    {
        if (desvanecer)
        {
            Color colorActual = spriteRenderer.color;
            colorActual.a -= Time.deltaTime / tiempoDesvanecer;
            spriteRenderer.color = colorActual;
        }
    }
}

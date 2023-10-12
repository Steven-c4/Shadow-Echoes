using UnityEngine;

public class ViejoControl : MonoBehaviour
{
    private Animator anim;
    private Collider2D hitbox;

    private void Start()
    {
        anim = GetComponent<Animator>();
        hitbox = GetComponentInChildren<Collider2D>(); // Asegúrate de configurar la capa adecuada para la hitbox.
        hitbox.enabled = false; // Desactiva la hitbox al inicio.
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Atacar();
        }
    }

    private void Atacar()
    {
        anim.SetTrigger("Ataque"); // Activa la animación de ataque en el Animator.
        hitbox.enabled = true; // Activa la hitbox durante el ataque.
    }
}


using UnityEngine;

public class EnemyOrientation : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Vector2 lastPosition; // Guardará la última posición del enemigo

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        lastPosition = transform.position; // Establece la última posición al iniciar
    }

    void Update()
    {
        float horizontalDirection = transform.position.x - lastPosition.x; // Obtiene la diferencia en la posición x desde la última actualización

        if (horizontalDirection > 0.01f) // Si la dirección es positiva, el enemigo se está moviendo hacia la derecha
        {
            spriteRenderer.flipX = false;
        }
        else if (horizontalDirection < -0.01f) // Si es negativa, el enemigo se está moviendo hacia la izquierda
        {
            spriteRenderer.flipX = true;
        }

        lastPosition = transform.position; // Actualiza la última posición para la próxima comprobación
    }
}

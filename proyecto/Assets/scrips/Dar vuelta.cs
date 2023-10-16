using UnityEngine;

public class FollowAI : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float minDistance;
    [SerializeField] private Transform player;
    [SerializeField] private Enemigo enemigo; // Agrega una referencia al script de Enemigo

    private bool isFacingRight = true;

    void Update()
    {
        if (enemigo.vida <= 0)
        {
            // Si la vida del enemigo es menor o igual a 0, no se mueve ni ataca
            return;
        }

        if (Vector2.Distance(transform.position, player.position) > minDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else
        {
            Attack();
        }

        bool isPlayerRight = transform.position.x < player.transform.position.x;
        Flip(isPlayerRight);
    }

    private void Attack()
    {
        Debug.Log("Atacar");
    }

    private void Flip(bool isPlayerRight)
    {
        if ((isFacingRight && !isPlayerRight) || (!isFacingRight && isPlayerRight))
        {
            isFacingRight = !isFacingRight;
            Vector3 scale = transform.localScale;
            scale.x *= -1;
            transform.localScale = scale;
        }
    }
}

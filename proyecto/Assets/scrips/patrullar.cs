using UnityEngine;

public class patrullar : MonoBehaviour
{
    private enum EnemyState { PATROLLING, CHASING }
    private EnemyState currentState;

    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private Transform[] puntosMovimiento;
    [SerializeField] private float distanciaMinima;

    private int numeroAleatorio;
    private Transform target; // Target para perseguir (el jugador)

    private SpriteRenderer SpriteRenderer;

    private void Start()
    {
        numeroAleatorio = Random.Range(0, puntosMovimiento.Length);
        SpriteRenderer = GetComponent<SpriteRenderer>();
        Girar();
        currentState = EnemyState.PATROLLING;
    }

    private void Update()
    {
        switch (currentState)
        {
            case EnemyState.PATROLLING:
                PatrollingLogic();
                break;

            case EnemyState.CHASING:
                ChasingLogic();
                break;
        }
    }

    private void PatrollingLogic()
    {
        transform.position = Vector2.MoveTowards(transform.position, puntosMovimiento[numeroAleatorio].position, velocidadMovimiento * Time.deltaTime);

        if (Vector2.Distance(transform.position, puntosMovimiento[numeroAleatorio].position) < distanciaMinima)
        {
            numeroAleatorio = Random.Range(0, puntosMovimiento.Length);
            Girar();
        }
    }

    private void ChasingLogic()
    {
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, velocidadMovimiento * Time.deltaTime);
        }
        else
        {
            currentState = EnemyState.PATROLLING; // Si no hay target, vuelve a patrullar
        }
    }

    private void Girar()
    {
        if (transform.position.x < puntosMovimiento[numeroAleatorio].position.x)
        {
            SpriteRenderer.flipX = false; // Corregido según tu lógica anterior
        }
        else
        {
            SpriteRenderer.flipX = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
{
    Debug.Log("Entidad detectada: " + other.name);
    if (other.CompareTag("player"))
    {
        Debug.Log("El jugador fue detectado");
        target = other.transform;
        currentState = EnemyState.CHASING;
    }
}

    private void OnTriggerExit2D(Collider2D other)
{
    Debug.Log("Entidad salió: " + other.name);
    if (other.CompareTag("player"))
    {
        Debug.Log("El jugador salió del rango");
        currentState = EnemyState.PATROLLING;
        }
    }
}

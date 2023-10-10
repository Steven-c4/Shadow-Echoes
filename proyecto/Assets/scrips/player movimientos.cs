using UnityEngine;

public class playerController2D : MonoBehaviour
{
    public float speed = 5.0f;
    public float runMultiplier = 1.5f;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isFacingRight = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        bool isMoving = moveHorizontal != 0 || moveVertical != 0;  
        bool isRunning = Input.GetKey(KeyCode.LeftShift) && isMoving;  

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement * (isRunning ? speed * runMultiplier : speed);

        animator.SetBool("Corriendo", isRunning);
        animator.SetFloat("Horizontal", movement.magnitude);

        // Cambio de dirección basado en el movimiento horizontal
        if (moveHorizontal > 0 && !isFacingRight)
        {
            Flip();
        }
        else if (moveHorizontal < 0 && isFacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}

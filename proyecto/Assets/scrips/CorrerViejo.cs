using UnityEngine;

public class RunWithShift : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        // Si se presiona Shift
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Y se presiona CUALQUIERA de las teclas direccionales
            if (Input.GetKey(KeyCode.UpArrow) || 
                Input.GetKey(KeyCode.DownArrow) || 
                Input.GetKey(KeyCode.LeftArrow) || 
                Input.GetKey(KeyCode.RightArrow))
            {
                animator.SetBool("Corriendo", true);
            }
            else
            {
                animator.SetBool("Corriendo", false);
            }
        }
        else
        {
            animator.SetBool("Corriendo", false);
        }
    }
}

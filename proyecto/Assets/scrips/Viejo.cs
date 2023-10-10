using UnityEngine;

public class CharacterClickAnimation : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("IsAnimating", false);  // Establece "IsAnimating" en falso al inicio
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            StartAnimation();
        }
        
        if (Input.GetKeyUp(KeyCode.X))
        {
            StopAnimation();
        }
    }

    void StartAnimation()
    {
        anim.SetBool("IsAnimating", true);
    }

    void StopAnimation()
    {
        anim.SetBool("IsAnimating", false);
    }
}

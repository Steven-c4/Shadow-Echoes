using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth = 100f;
    public Slider healthSlider; // Referencia al Slider de la barra de vida en el Inspector.


    public float damageAmount = 10f; // Cantidad de daño al presionar la tecla "F"

    private void Start()
    {
        // Inicializa la salud al valor máximo.
        currentHealth = maxHealth;

        // Configura el valor máximo del Slider.
        healthSlider.maxValue = maxHealth;

        // Asegúrate de que el Slider refleje el valor de la salud inicial.
        healthSlider.value = currentHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Aplica el daño al personaje cuando se presiona la tecla "F".
            TakeDamage(damageAmount);
        }
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;

        // Actualiza el valor del Slider para reflejar la vida actual.
        healthSlider.value = currentHealth;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Implementar animacion de muerte

        gameObject.SetActive(false);
    }
}

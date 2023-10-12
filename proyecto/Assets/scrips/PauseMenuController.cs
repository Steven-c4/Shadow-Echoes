using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseMenu; // Referencia al panel de pausa en el Inspector.
    public string mainMenuSceneName = "MainMenu"; // El nombre de la escena del menú principal.

    private bool isPaused = false;

    private void Start()
    {
        // Asegúrate de que el menú de pausa esté desactivado al inicio.
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Activa/desactiva el menú de pausa y pausa/despausa el juego.
            TogglePause();
        }
    }

    public void TogglePause()
    {
        if (isPaused)
        {
            // El juego está pausado, reanudarlo.
            Time.timeScale = 1f;
            isPaused = false;
            pauseMenu.SetActive(false);
        }
        else
        {
            // El juego no está pausado, pausarlo.
            Time.timeScale = 0f;
            isPaused = true;
            pauseMenu.SetActive(true);
        }
    }

    public void LoadMainMenu()
    {
        // Carga la escena del menú principal.
        SceneManager.LoadScene(mainMenuSceneName);
    }
}

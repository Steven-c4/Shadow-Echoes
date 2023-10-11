using UnityEngine;
using UnityEngine.SceneManagment;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    [SerializeField] private GameObject -pausebutton;
    {
        SceneManager .LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit()
    }
}
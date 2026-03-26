using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("SurviveTheBombs");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

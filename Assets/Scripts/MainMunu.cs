using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMunu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Startgame()
    {
        SceneManager.LoadScene("Load");
    }

    public void LoadSavegame()
    {
        SceneManager.LoadScene("Load");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

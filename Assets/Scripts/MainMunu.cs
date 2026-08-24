using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMunu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Startgame()
    {
        Settings.fromSave = false;
        SceneManager.LoadScene("Loading");
    }

    public void LoadSavegame()
    {
        Settings.fromSave = false;
        SceneManager.LoadScene("Loading");
    }

    public void Exit()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private bool IsMute = false;
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void StartSettingsMenu()
    {
        SceneManager.LoadScene("SettingsScane");
    }
    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    public void SoundsController()
    {
        if (IsMute)
        {
            IsMute = !IsMute;
        }
    }
}

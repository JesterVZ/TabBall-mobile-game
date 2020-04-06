using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void StartGame()
    {
        if (CountOfLivesForStart.CountOfLives > 0)
        {
            CountOfLivesForStart.CountOfLives--;
            PlayerPrefs.SetInt("CountOfLives", CountOfLivesForStart.CountOfLives);
            SceneManager.LoadScene("SampleScene");
        } else
        {

        }
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

}

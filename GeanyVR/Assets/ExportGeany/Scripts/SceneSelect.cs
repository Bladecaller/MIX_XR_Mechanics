using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSelect : MonoBehaviour
{
    public void MagicMinigame()
    {
        SceneManager.LoadScene("MoodyNight");
    }
    public void ShootingGame()
    {
        SceneManager.LoadScene("Playground");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

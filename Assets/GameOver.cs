using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("game");
    }
}

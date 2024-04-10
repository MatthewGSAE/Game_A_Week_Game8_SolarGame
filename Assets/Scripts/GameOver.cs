using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string menuSceneName = "MainMenu";

    public FadeMaster FadeMaster;

    public void Retry()
    {
        FadeMaster.FadeTo(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        FadeMaster.FadeTo(menuSceneName);
    }
}

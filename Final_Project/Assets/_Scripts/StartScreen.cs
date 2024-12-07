using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class StartScreen : MonoBehaviour
{

    public string levelOne;
    public GameObject popUpPanel;
    public void startGame()
    {
        SceneManager.LoadScene(levelOne);
    }

    public void ExitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();
    }
    public void ShowPopUp()
    {
        popUpPanel.SetActive(true);
    }
    public void HidePopUp()
    {
        popUpPanel.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject panelPause;

    public void PauseMenu()
    {
        panelPause.SetActive(true);
        Time.timeScale = 0.0f;
        Debug.Log("Pause");
    }

    public void UnPauseMenu()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void GoToMainMenu()
    {
        panelPause.SetActive(false);
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Main Menu");
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Game");
    }
    public void CloseApplication()
    {
        Application.Quit();
        Debug.Log("App is close");
    }
}

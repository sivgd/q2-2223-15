using UnityEngine.SceneManagement;
using UnityEngine;

public class CreditSceneMenu : MonoBehaviour
{
    public string gameScene;

    public void NewGame()
    {
        SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

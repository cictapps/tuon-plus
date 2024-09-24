using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishedSceneManager : MonoBehaviour
{
    public Button replayButton;
    public Button mainMenuButton;

    private void Start()
    {
        replayButton.onClick.AddListener(ReplayGame);
        mainMenuButton.onClick.AddListener(GoToMainMenu);
    }

    private void ReplayGame()
    {
        SceneManager.LoadScene("A"); // Replace with the name of your game scene
    }

    private void GoToMainMenu()
    {
        SceneManager.LoadScene("Main"); // Replace with the name of your main menu scene
    }
}

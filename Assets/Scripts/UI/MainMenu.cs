using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : Menu
{
    [SerializeField] private Button startGameButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button exitGameButton;

    public override void Initialize()
    {
        startGameButton.onClick.AddListener(StartGame);
        settingsButton.onClick.AddListener(Settings);
        exitGameButton.onClick.AddListener(ExitGame);
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    private void Settings()
    {
        menuManager.Show<Settings>();
    }

    private void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
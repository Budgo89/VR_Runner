using _root.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private PauseMenager _pauseMenager;
    [SerializeField] private Button _startButton;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private GameObject _settingsMenu;
    [SerializeField] private Button _continueButton;
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _exitButton;


    void Start()
    {
        _pauseMenager.EnablePause();
        _startButton.gameObject.SetActive(true);
        _startButton.onClick.AddListener(OnStartGameButtonClick);
        _settingsButton.onClick.AddListener(OnSettingsButtonClick);
        _continueButton.onClick.AddListener(OnContinueButtonClick);
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _exitButton.onClick.AddListener(OnExitButtonClick);
    }

    private void OnExitButtonClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    private void OnRestartButtonClick()
    {
        SceneManager.LoadScene(0);
    }

    private void OnContinueButtonClick()
    {
        _pauseMenager.DisablePause();
        _settingsMenu.gameObject.SetActive(false);
        _settingsButton.gameObject.SetActive(true);
    }

    private void OnSettingsButtonClick()
    {
        _pauseMenager.EnablePause();
        _settingsMenu.gameObject.SetActive(true);
        _startButton.gameObject.SetActive(false);
        _settingsButton.gameObject.SetActive(false);
    }

    private void OnStartGameButtonClick()
    {
        _pauseMenager.DisablePause();
        _startButton.gameObject.SetActive(false);
        _startButton.onClick.RemoveAllListeners();
    }
}

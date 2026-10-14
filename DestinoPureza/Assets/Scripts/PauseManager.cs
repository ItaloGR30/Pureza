using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;

    private bool isPaused = false;

    private void Awake()
    {
        // Garante que a fase comece sem estar pausada.
        Time.timeScale = 1f;
    }

    private void Start()
    {
        if (pausePanel != null)
            pausePanel.SetActive(false);
    }

    public void PauseGame()
    {
        if (isPaused) return;

        isPaused = true;
        Time.timeScale = 0f;

        if (pausePanel != null)
            pausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f;

        if (pausePanel != null)
            pausePanel.SetActive(false);
    }

    public void RestartStage()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name
        );
    }

    public void BackToMap()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Mapa");
    }
}

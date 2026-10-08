using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryButtons : MonoBehaviour
{
    [SerializeField] private int currentStage = 1;

    public void NextStage()
    {
        int nextStage = currentStage + 1;

        string nextScene = "Fase_" + nextStage.ToString("00");

        SceneManager.LoadScene(nextScene);
    }

    public void BackToMap()
    {
        SceneManager.LoadScene("Mapa");
    }
}
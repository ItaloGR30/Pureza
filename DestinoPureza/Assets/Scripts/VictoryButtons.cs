using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryButtons : MonoBehaviour
{
    public void NextStage()
    {
        SceneManager.LoadScene("Fase_02");
    }

    public void BackToMap()
    {
        SceneManager.LoadScene("Mapa");
    }
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCompleteButtons : MonoBehaviour
{
    public void ReplayGame()
    {
        SceneManager.LoadScene("Fase_01");
    }

    public void BackToMap()
    {
        SceneManager.LoadScene("Mapa");
    }
}
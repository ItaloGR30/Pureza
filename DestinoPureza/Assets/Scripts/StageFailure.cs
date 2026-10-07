using UnityEngine;
using UnityEngine.SceneManagement;

public class StageFailure : MonoBehaviour
{
    private bool failed = false;

    public void FailStage()
    {
        if (failed)
            return;

        failed = true;

        Debug.Log("Fase perdida!");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using UnityEngine;

public class ResetProgress : MonoBehaviour
{
    public void ResetGameProgress()
    {
        StageProgress.ResetProgress();

        Debug.Log("Progresso resetado!");
    }
}
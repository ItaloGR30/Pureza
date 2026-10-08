using UnityEngine;

public class StageFinish : MonoBehaviour
{
    [SerializeField] private GameObject victoryPanel;
    [SerializeField] private GameObject gameCompletePanel;
    [SerializeField] private int stageNumber = 1;
    [SerializeField] private int totalStages = 7;

    private bool finished = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (finished)
            return;

        if (collision.CompareTag("Player"))
        {
            finished = true;

            Debug.Log("Fase concluída!");

            StageProgress.UnlockNextStage(stageNumber);

            if (stageNumber >= totalStages)
            {
                if (gameCompletePanel != null)
                    gameCompletePanel.SetActive(true);
            }
            else
            {
                if (victoryPanel != null)
                    victoryPanel.SetActive(true);
            }
        }
    }
}
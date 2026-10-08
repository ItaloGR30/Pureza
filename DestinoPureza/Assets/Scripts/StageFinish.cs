using UnityEngine;

public class StageFinish : MonoBehaviour
{
    [SerializeField] private GameObject victoryPanel;
    [SerializeField] private int stageNumber = 1;

    private bool finished = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (finished)
            return;

        if (collision.CompareTag("Player"))
        {
            finished = true;

            Debug.Log("Fase concluída!");

            // Desbloqueia a próxima fase
            StageProgress.UnlockNextStage(stageNumber);

            // Mostra a tela de vitória
            if (victoryPanel != null)
            {
                victoryPanel.SetActive(true);
            }
        }
    }
}
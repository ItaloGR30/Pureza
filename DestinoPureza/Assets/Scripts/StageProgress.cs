
using UnityEngine;

public static class StageProgress
{
    private const string SaveKey =
        "DestinoPureza_HighestUnlockedStage";

    // Carrega o progresso salvo.
    // Se não existir save, começa na Fase 1.
    public static int HighestUnlockedStage
    {
        get
        {
            return PlayerPrefs.GetInt(SaveKey, 1);
        }
    }

    public static bool IsUnlocked(int stageNumber)
    {
        return stageNumber <= HighestUnlockedStage;
    }

    // Salva o desbloqueio da próxima fase.
    public static void UnlockNextStage(int completedStageNumber)
    {
        int nextStage = completedStageNumber + 1;

        if (nextStage > HighestUnlockedStage)
        {
            PlayerPrefs.SetInt(SaveKey, nextStage);
            PlayerPrefs.Save();

            Debug.Log("Progresso salvo! Fase " +
                      nextStage + " desbloqueada.");
        }
    }

    // Reseta o progresso durante os testes.
    public static void ResetProgress()
    {
        PlayerPrefs.DeleteKey(SaveKey);
        PlayerPrefs.Save();

        Debug.Log("Progresso resetado!");
    }
}

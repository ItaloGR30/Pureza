using UnityEngine;

public static class StageProgress
{
    private const string SaveKey = "DestinoPureza_HighestUnlockedStage";

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

    public static void UnlockNextStage(int completedStageNumber)
    {
        int nextStage = completedStageNumber + 1;

        if (nextStage > HighestUnlockedStage)
        {
            PlayerPrefs.SetInt(SaveKey, nextStage);
            PlayerPrefs.Save();
        }
    }

    public static void ResetProgress()
    {
        PlayerPrefs.DeleteKey(SaveKey);
        PlayerPrefs.Save();
    }
}
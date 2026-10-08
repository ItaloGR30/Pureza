using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StageButton : MonoBehaviour
{
    [Header("Configuracao da fase")]
    [SerializeField] private int stageNumber = 1;
    [SerializeField] private string sceneName = "Fase_01";

    [Header("Elementos visuais")]
    [SerializeField] private Button button;
    [SerializeField] private GameObject lockIcon;
    [SerializeField] private TMP_Text stageLabel;

    private void Awake()
    {
        if (button == null)
            button = GetComponent<Button>();

        button.onClick.AddListener(OpenStage);
    }

    private void Start()
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        bool unlocked = StageProgress.IsUnlocked(stageNumber);

        button.interactable = unlocked;

        if (lockIcon != null)
            lockIcon.SetActive(!unlocked);

        if (stageLabel != null)
            stageLabel.text = "Fase " + stageNumber;
    }

    private void OpenStage()
    {
        if (!StageProgress.IsUnlocked(stageNumber))
            return;

        SceneManager.LoadScene(sceneName);
    }
}
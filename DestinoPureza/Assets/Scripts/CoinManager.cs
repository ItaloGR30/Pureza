
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;

    [SerializeField] private TMP_Text coinText;

    private int totalCoins = 0;

    private void Awake()
    {
        Instance = this;
        totalCoins = 0;
        UpdateCoinText();
    }

    public void AddCoin()
    {
        totalCoins++;
        UpdateCoinText();

        Debug.Log("Moedas coletadas: " + totalCoins);
    }

    private void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = "Moedas: " + totalCoins;
        }
    }
}

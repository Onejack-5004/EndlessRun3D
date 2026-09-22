using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI coinText;

    private int coinScore = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateCoinUI();
    }

    public void AddCoin(int amount)
    {
        coinScore += amount;

        UpdateCoinUI();
    }

    public void UpdateCoinUI()
    {
        coinText.text = "Coins: " + coinScore;
    }
    public int GetCoinScore()
    {
        return coinScore;
    }
}
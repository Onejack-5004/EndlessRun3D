using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverPanel;

    public TextMeshProUGUI finalCoinText;
    public TextMeshProUGUI finalDistanceText;

    public GameObject coinText;
    public GameObject distanceText;

    private bool gameOver = false;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    public void GameOver()
    {
        if (gameOver)
            return;

        gameOver = true;

        coinText.SetActive(false);
        distanceText.SetActive(false);

        // หยุดเกม
        Time.timeScale = 0f;

        // แสดงคะแนนเหรียญ
        finalCoinText.text = "Coins: " + ScoreManager.instance.GetCoinScore();

        // แสดงระยะทาง
        finalDistanceText.text = "Distance: " + DistanceManager.instance.GetDistance() + " m";

        // เปิด Game Over Panel
        gameOverPanel.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Time.timeScale = 1f;

        Debug.Log("Exit Game");

        Application.Quit();
    }
}
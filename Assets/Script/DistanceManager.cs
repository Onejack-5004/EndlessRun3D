using UnityEngine;
using TMPro;

public class DistanceManager : MonoBehaviour
{
    public static DistanceManager instance;

    public float speed = 5f;

    public TextMeshProUGUI distanceText;

    private float distance = 0f;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        distance += speed * Time.deltaTime;

        UpdateDistanceUI();
    }

    void UpdateDistanceUI()
    {
        distanceText.text = "Distance: " + Mathf.FloorToInt(distance) + " m";
    }

    public int GetDistance()
    {
        return Mathf.FloorToInt(distance);
    }
}
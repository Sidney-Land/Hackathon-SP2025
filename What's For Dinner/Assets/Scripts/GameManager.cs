using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float maximamTime;
    public TextMeshProUGUI txtTimer;

    private float timer;

    private void Awake()
    {
        timer = maximamTime;
    }

    private void Update()
    {
        UpdateTimer();
    }

    private void UpdateTimer()
    {
        timer -= Time.deltaTime;

        int hours = (int)(timer / 3600);
        int minutes = (int)((timer - hours * 3600) / 60);
        int seconds = (int)(timer - hours * 3600 - minutes * 60);
        int milliSeconds = (int)((timer - ((int)(timer))) * 1000);

        string outputTxt = $"{hours}:{minutes}:{seconds}:{milliSeconds}";
        txtTimer.text = outputTxt;
    }
}
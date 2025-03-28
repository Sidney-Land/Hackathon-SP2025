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

        string hoursString = hours >= 10 ? hours.ToString() : "0" + hours.ToString();
        string minutesString = minutes >= 10 ? minutes.ToString() : "0" + minutes.ToString();
        string secondsString = seconds >= 10 ? seconds.ToString() : "0" + seconds.ToString();
        string milliSecondsString;
        if (milliSeconds >= 100)
            milliSecondsString = milliSeconds.ToString();
        else if (milliSeconds >= 10 && milliSeconds < 100)
            milliSecondsString = "0" + milliSeconds.ToString();
        else
            milliSecondsString = "00" + milliSeconds.ToString();

        string outputTxt = $"{hoursString}:{minutesString}:{secondsString}:{milliSecondsString}";
        txtTimer.text = outputTxt;
    }
}
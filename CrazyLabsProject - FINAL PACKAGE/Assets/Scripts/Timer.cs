using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeValue;
    public Text TimerText;
    public GameObject GameLosePanel;
    public Button HitButton;
    void Start()
    {
        TimeValue = InGameSettings.Settings_TimeLimit * 60;
        GameLosePanel.gameObject.SetActive(false);
    }
    void Update()
    {
        if(TimeValue > 0)
        {
            TimeValue -= Time.deltaTime;
        }
        else
        {
            TimeValue = 0;
            GameLosePanel.gameObject.SetActive(true);
            HitButton.gameObject.SetActive(false);
        }
        DisplayTime(TimeValue);
    }
    void DisplayTime(float TimeToDisplay)
    {
        if(TimeToDisplay < 0)
        {
            TimeToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(TimeToDisplay / 60);
        float seconds = Mathf.FloorToInt(TimeToDisplay % 60);
        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeStamp : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        // Call the GetTime method initially to update the time display
        GetTime();
    }

    // Update is called once per frame
    void Update()
    {
        // Call the GetTime method each frame to keep the time updated
        GetTime();
    }

    void GetTime()
    {
        // Get the current time in seconds
        float currentTime = Time.time;

        // Calculate the time offset to start at 11:25:26
        int startHour = 11;
        int startMinute = 25;
        int startSecond = 26;
        float timeOffset = (startHour * 3600) + (startMinute * 60) + startSecond;

        // Calculate the adjusted time
        float adjustedTime = currentTime + timeOffset;

        // Calculate hours, minutes, and seconds
        int hours = (int)(adjustedTime / 3600) % 24;
        int minutes = (int)(adjustedTime / 60) % 60;
        int seconds = (int)adjustedTime % 60;

        // Format the time as a string in the "00:00:00" format
        string formattedTime = hours.ToString("00") + ":" + minutes.ToString("00") + ":" + seconds.ToString("00");

        // Update the UI text
        timeText.text = formattedTime;
    }


}


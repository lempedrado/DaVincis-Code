using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeObj : MonoBehaviour
{
    public bool running = false;
    public Text timeText;
    private float timeRemaining;

    private void Start()
    {
        running = true;
    }

    /** Updated the countdown timer. */
    void Update()
    {
        //if timer is active, count down
        if(running)
        {
            if(timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            //when the timer runs out
            else
            {
                Debug.Log("Timer has ended");
                timeRemaining = 0;
                running = false;
            }
            display(timeRemaining);
        }
    }

    //set the timer value in seconds
    /**
     *  The total amount of time to set the timer in seconds.
     */
    public void setTimer(float time)
    {
        timeRemaining = time;
    }

    /** Formats the seconds left on the timer as M:SS */
    void display(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

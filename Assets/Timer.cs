using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool running = false;
    public Text timeText;
    private float timeRemaining;

    private void Start()
    {
        running = true;
    }

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
    public void setTimer(float time)
    {
        timeRemaining = time;
    }

    //formats the passed float into a string with minutes and seconds
    void display(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

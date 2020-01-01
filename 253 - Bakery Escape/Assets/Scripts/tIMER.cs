using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class tIMER : MonoBehaviour
{
    public double timeLeft = 30f;
    public TextMeshProUGUI timerLabel;
    public bool timerIsActive = true;
    public GameManager GM;
    public bool timerCountsDown = true;
    public float currentTime;
    public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        if (!timerCountsDown)
        {
            startTime = Time.time;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        countDownUpdate();


    }

    public void countDownUpdate()
    {
        if (timerIsActive == true)
        {
            timeLeft -= Time.deltaTime;
            //Debug.Log(timeLeft);
            if (timeLeft <= 0)
            {
                setTimerBool(false);
                timeLeft = 0.0000f;
                
                GM.loseScreen();
            }

            //update text label
            timeLeft = Math.Round(timeLeft, 2);
            timerLabel.text = timeLeft.ToString();
        }
        else if (timerIsActive == false)
        {
            timerLabel.color = (Color.green);
        }
    }

    public void stopTimer()
    {
        setTimerBool(false);
    }

    public void setTimerBool(bool input)
    {
        timerIsActive = input;
    }
    


}

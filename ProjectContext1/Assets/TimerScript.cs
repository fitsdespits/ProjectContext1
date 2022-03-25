using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Video;

public class TimerScript : MonoBehaviour
{
    public float timeValue = 120;
    public float timeValue2 = 0;
    public TextMeshProUGUI timeText;

    private bool active = false;

    public GameObject explosion;
    public GameObject program;
    public GameObject program2;
    public GameObject icon;
    
    public VideoPlayer player;

    public bool started = false;
    public bool finished = false;

    private void Update()
    {
        if (active && timeValue > 0)
        {
            timeValue -= Time.deltaTime;
            started = true;
        }

        DisplayTime(timeValue);
        
        //After time is up
        if (timeValue < 0 && started)
        {
            explosion.gameObject.SetActive(true);
            player.Play();
            finished = true;
        }

        if (finished && started)
        {
            timeValue2 += Time.deltaTime;
        }

        if(timeValue2 > 15)
        {
            explosion.gameObject.SetActive(false);
            program.gameObject.SetActive(false);
            program2.gameObject.SetActive(false);
            icon.gameObject.SetActive(true);
            player.Stop();
            started = false;
            finished = false;
        }
    }

    private void OnEnable()
    {
        active = true;
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

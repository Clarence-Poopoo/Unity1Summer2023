using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float timeStart;
    public int minute;
    public int second;
    public TMP_Text timerText;
    public bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        timeStart = 0;
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameOver)
        {
            TimerUpdate();
        }
    }

    void TimerUpdate()
    {
        timeStart += Time.deltaTime;
        minute = Mathf.FloorToInt(timeStart / 60);
        second = Mathf.FloorToInt(timeStart % 60);
        if(second > 9)
        {
            timerText.text = $"{minute}:{second}";
        }
        else
        {
            timerText.text = $"{minute}:0{second}";
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text stopwatchText;
    public float time;
    private float elapsedTime = 0f;
    private bool isRunning = false;

    void Update()
    {
        if (isRunning)
        {
            
            elapsedTime += Time.deltaTime;

            
            DisplayTime(elapsedTime);
        }
    }

    void DisplayTime(float time)
    {
        // 시간을 분, 초, 밀리초로 변환
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        int milliseconds = Mathf.FloorToInt((time * 1000f) % 1000f);

        // 텍스트 업데이트
        stopwatchText.text = string.Format("경과 시간 : {0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    public void StartStopwatch()
    {
        // 스톱워치 시작
        isRunning = true;
    }

    public void StopStopwatch()
    {
        // 스톱워치 정지
        isRunning = false;
        time = elapsedTime;
    }

    public void ResetStopwatch()
    {
        // 스톱워치 초기화
        elapsedTime = 0f;
        DisplayTime(elapsedTime);
    }
}
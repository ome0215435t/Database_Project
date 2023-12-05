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
        // �ð��� ��, ��, �и��ʷ� ��ȯ
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        int milliseconds = Mathf.FloorToInt((time * 1000f) % 1000f);

        // �ؽ�Ʈ ������Ʈ
        stopwatchText.text = string.Format("��� �ð� : {0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    public void StartStopwatch()
    {
        // �����ġ ����
        isRunning = true;
    }

    public void StopStopwatch()
    {
        // �����ġ ����
        isRunning = false;
        time = elapsedTime;
    }

    public void ResetStopwatch()
    {
        // �����ġ �ʱ�ȭ
        elapsedTime = 0f;
        DisplayTime(elapsedTime);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameTimer : MonoBehaviour
{
    public Text timerText;

    private float elapsedTime = 0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        UpdateTimerUI();

        if (Input.GetKeyDown(KeyCode.H))
        {
            // 시간을 텍스트 파일에 저장
            SaveTimeToFile(timerText.text);
        }
    }

    void UpdateTimerUI()
    {
        float minutes = Mathf.FloorToInt(elapsedTime / 60);
        float seconds = Mathf.FloorToInt(elapsedTime % 60);
        float milliseconds = (elapsedTime * 1000) % 1000;

        timerText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliseconds);
    }

    void SaveTimeToFile(string timeString)
    {
        // 저장할 파일 경로 및 파일명 설정 (경로는 적절하게 수정하세요)
        string filePath = Path.Combine(Application.dataPath, "SavedTime.txt");

        // 시간을 파일에 기록
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine("Button pressed at: " + timeString);
        }

        Debug.Log("Time saved to file: " + timeString);
    }
}

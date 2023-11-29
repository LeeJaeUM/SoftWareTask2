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
            // �ð��� �ؽ�Ʈ ���Ͽ� ����
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
        // ������ ���� ��� �� ���ϸ� ���� (��δ� �����ϰ� �����ϼ���)
        string filePath = Path.Combine(Application.dataPath, "SavedTime.txt");

        // �ð��� ���Ͽ� ���
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine("Button pressed at: " + timeString);
        }

        Debug.Log("Time saved to file: " + timeString);
    }
}

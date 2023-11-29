using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text myText;

    void Start()
    {
        StartCoroutine(BlinkText(1f, 0.8f));
    }

    IEnumerator BlinkText(float delay, float blinkDuration)
    {
        yield return new WaitForSeconds(delay);

        // ���������� �ݺ��� ���� ����Ʈ
        bool[] states = { false, true, false, true, false };

        foreach (bool state in states)
        {
            myText.gameObject.SetActive(state);
            yield return new WaitForSeconds(blinkDuration);
        }

        // �ݺ��� ������ Text�� ������ ���·� ����
        myText.gameObject.SetActive(false);
    }
}

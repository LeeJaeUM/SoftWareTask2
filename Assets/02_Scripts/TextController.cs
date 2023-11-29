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

        // 순차적으로 반복할 상태 리스트
        bool[] states = { false, true, false, true, false };

        foreach (bool state in states)
        {
            myText.gameObject.SetActive(state);
            yield return new WaitForSeconds(blinkDuration);
        }

        // 반복이 끝나면 Text를 마지막 상태로 설정
        myText.gameObject.SetActive(false);
    }
}

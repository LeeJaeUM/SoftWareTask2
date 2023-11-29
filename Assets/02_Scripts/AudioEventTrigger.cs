using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEventTrigger : MonoBehaviour
{
    public PressNote pressNote;

    void Start()
    {

        // 8초 후에 YourFunctionToInvoke() 함수 호출
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 7.8f));

        // 13.8초 후에 YourFunctionToInvoke() 함수 호출
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 13.6f));
    }

    IEnumerator InvokeFunctionAfterDelay(System.Action functionToInvoke, float delay)
    {
        yield return new WaitForSeconds(delay);
        functionToInvoke?.Invoke();
    }

    void YourFunctionToInvoke()
    {
        // 실행할 함수
        pressNote.SetCanPressNote();
    }
}

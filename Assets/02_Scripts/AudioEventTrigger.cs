using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEventTrigger : MonoBehaviour
{
    public PressNote pressNote;

    void Start()
    {

        // 8초 후에 YourFunctionToInvoke() 함수 호출
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 7.81f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 13.193f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 17.574f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 22.481f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 24.329f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 27.55f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 33.099f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 37.417f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 42.313f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 44.093f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 51.288f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 53.116f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 54.915f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 56.582f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 58.528f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 60.351f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 62.155f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 63.356f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 65.619f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 69.718f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 72.919f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 76.551f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 77.816f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 82.047f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 83.816f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 86.144f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 87.477f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 89.321f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 91.124f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 92.923f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 96.766f));
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

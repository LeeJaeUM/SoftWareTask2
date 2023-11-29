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
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 13.293f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 17.674f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 22.581f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 24.429f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 27.65f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 33.199f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 37.517f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 42.413f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 44.193f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 51.388f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 53.216f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 55.015f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 56.682f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 58.628f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 60.451f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 62.255f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 63.456f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 65.719f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 69.818f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 73.019f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 76.651f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 77.916f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 82.147f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 83.916f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 86.244f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 87.577f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 89.421f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 91.224f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 93.023f));
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 96.866f));
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

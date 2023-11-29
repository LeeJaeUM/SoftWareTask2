using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEventTrigger : MonoBehaviour
{
    public PressNote pressNote;

    void Start()
    {

        // 8�� �Ŀ� YourFunctionToInvoke() �Լ� ȣ��
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 7.8f));

        // 13.8�� �Ŀ� YourFunctionToInvoke() �Լ� ȣ��
        StartCoroutine(InvokeFunctionAfterDelay(YourFunctionToInvoke, 13.6f));
    }

    IEnumerator InvokeFunctionAfterDelay(System.Action functionToInvoke, float delay)
    {
        yield return new WaitForSeconds(delay);
        functionToInvoke?.Invoke();
    }

    void YourFunctionToInvoke()
    {
        // ������ �Լ�
        pressNote.SetCanPressNote();
    }
}

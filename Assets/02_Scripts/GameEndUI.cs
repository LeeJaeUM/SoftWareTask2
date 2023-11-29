using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndUI : MonoBehaviour
{
    public GameObject uiObject1;
    public GameObject uiObject2;

    // �ٸ� ������ ȣ���Ͽ� ����� �� �ֵ��� public �޼��� ����
    public void ToggleUIObjects()
    {
        // �� UI ������Ʈ�� ��� ��Ȱ��ȭ
        uiObject1.SetActive(false);
        uiObject2.SetActive(false);

        // activateFirstObject�� true�̸� ù ��° UI ������Ʈ�� Ȱ��ȭ, �׷��� ������ �� ��° UI ������Ʈ�� Ȱ��ȭ
        if (GameManager.Instance.missCount < 3)
        {
            uiObject1.SetActive(true);
        }
        else
        {
            uiObject2.SetActive(true);
        }
    }
}

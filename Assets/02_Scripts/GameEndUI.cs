using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndUI : MonoBehaviour
{
    public GameObject uiObject1;
    public GameObject uiObject2;

    // 다른 곳에서 호출하여 사용할 수 있도록 public 메서드 생성
    public void ToggleUIObjects()
    {
        // 두 UI 오브젝트를 모두 비활성화
        uiObject1.SetActive(false);
        uiObject2.SetActive(false);

        // activateFirstObject가 true이면 첫 번째 UI 오브젝트를 활성화, 그렇지 않으면 두 번째 UI 오브젝트를 활성화
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

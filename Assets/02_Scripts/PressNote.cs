using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressNote : MonoBehaviour
{
    public bool canPressNote = false;    // 노트를 누를 수 있는지 여부
    private float noteReleaseStartTime;    // 노트를 뗀 시작 시간
    private float releaseDuration = 0;

    void Update()
    {
        if (Input.GetMouseButtonUp(2))
        {
            Debug.Log(noteReleaseStartTime);
        }
        if (Input.GetKeyDown(KeyCode.V)){
            SetCanPressNote();
        }
        // 노트를 누를 수 있는 상태에서 마우스 왼쪽 버튼이 떼어졌을 때
        if (canPressNote && Input.GetMouseButtonUp(0))
        {
            releaseDuration = Time.time - noteReleaseStartTime;
            
            if (releaseDuration <= 0.2f)
            {
                // 너무 빨리 뗏을때
                Debug.LogWarning("너무 빨리 노트를 뗐습니다!--------------");
                GameManager.Instance.missCount++;

            }
            // 노트를 떼는데 0.4초 이내면 "적절한 타이밍"으로 간주
            if (releaseDuration > 0.2f && releaseDuration <= 0.6f)
            {
                // 적절한 타이밍에 노트를 뗐을 때의 처리
                Debug.LogWarning("적절한 타이밍으로 노트를 뗐습니다!");

                // 여기에 점수 증가 등의 처리를 추가할 수 있습니다.
            }
            if (releaseDuration > 0.6f)
            {
                // 너무 느리게 뗏을때
                Debug.LogWarning("-------- 느리게 노트를 뜨에엇스읍니드아.");
                GameManager.Instance.missCount++;

            }
            Debug.Log(noteReleaseStartTime);

            Debug.Log("디버그용");
            Debug.Log(releaseDuration);
            // 변수 초기화
            canPressNote = false;
        }
    }

    // 노트를 누를 수 있는지 여부를 설정하는 함수
    public void SetCanPressNote()
    {
        noteReleaseStartTime = Time.time;
        canPressNote = true;
    }
}

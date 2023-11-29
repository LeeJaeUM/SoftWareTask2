using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressNote : MonoBehaviour
{
    public bool canPressNote = false;    // 노트를 누를 수 있는지 여부
    private float noteReleaseStartTime;    // 노트를 뗀 시작 시간
    private float releaseDuration = 0;
    public Animator anim;

    void Update()
    {
        releaseDuration += Time.deltaTime;
        if (Input.GetMouseButtonUp(2))
        {
            Debug.Log(noteReleaseStartTime);
        }
        if (Input.GetKeyDown(KeyCode.V)){
            SetCanPressNote();
        }
        if (canPressNote)
        {
            noteReleaseStartTime += Time.deltaTime;
        }
        // 노트를 누를 수 있는 상태에서 마우스 왼쪽 버튼이 떼어졌을 때
        if (canPressNote && Input.GetMouseButtonDown(0))
        {
            GameManager.Instance.milisec = noteReleaseStartTime;
            //releaseDuration = Time.time - noteReleaseStartTime;
            // 노트를 떼는데 0.1 ~ 0.4초 이내면 "적절한 타이밍"으로 간주 releaseDuration > 0.1f && 
            // 0.8초로 변경
            if (noteReleaseStartTime <= 0.5f)
            {
                // 적절한 타이밍에 노트를 뗐을 때의 처리
                Debug.LogWarning("적절한 타이밍으로 노트를 뗐습니다!");
                anim.SetTrigger("Good");
                GameManager.Instance.goodCount++;

            }
            if (noteReleaseStartTime > 0.5f)
            {
                // 너무 느리게 뗏을때
                Debug.LogWarning("-------- 느리게 노트를 뜨에엇스읍니드아.");
                anim.SetTrigger("miss");
                GameManager.Instance.missCount++;

            }
            Debug.Log("누른 시간");
            Debug.Log(releaseDuration);
            Debug.Log(noteReleaseStartTime);
            // 변수 초기화
            noteReleaseStartTime = 0;
            canPressNote = false;
        }
    }

    // 노트를 누를 수 있는지 여부를 설정하는 함수
    public void SetCanPressNote()
    {
        //noteReleaseStartTime = Time.time;
        canPressNote = true;
    }
}

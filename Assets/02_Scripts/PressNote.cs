using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressNote : MonoBehaviour
{
    public bool canPressNote = false;    // ��Ʈ�� ���� �� �ִ��� ����
    private float noteReleaseStartTime;    // ��Ʈ�� �� ���� �ð�
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
        // ��Ʈ�� ���� �� �ִ� ���¿��� ���콺 ���� ��ư�� �������� ��
        if (canPressNote && Input.GetMouseButtonDown(0))
        {
            GameManager.Instance.milisec = noteReleaseStartTime;
            //releaseDuration = Time.time - noteReleaseStartTime;
            // ��Ʈ�� ���µ� 0.1 ~ 0.4�� �̳��� "������ Ÿ�̹�"���� ���� releaseDuration > 0.1f && 
            // 0.8�ʷ� ����
            if (noteReleaseStartTime <= 0.5f)
            {
                // ������ Ÿ�ֿ̹� ��Ʈ�� ���� ���� ó��
                Debug.LogWarning("������ Ÿ�̹����� ��Ʈ�� �ý��ϴ�!");
                anim.SetTrigger("Good");
                GameManager.Instance.goodCount++;

            }
            if (noteReleaseStartTime > 0.5f)
            {
                // �ʹ� ������ ������
                Debug.LogWarning("-------- ������ ��Ʈ�� �߿��������ϵ��.");
                anim.SetTrigger("miss");
                GameManager.Instance.missCount++;

            }
            Debug.Log("���� �ð�");
            Debug.Log(releaseDuration);
            Debug.Log(noteReleaseStartTime);
            // ���� �ʱ�ȭ
            noteReleaseStartTime = 0;
            canPressNote = false;
        }
    }

    // ��Ʈ�� ���� �� �ִ��� ���θ� �����ϴ� �Լ�
    public void SetCanPressNote()
    {
        //noteReleaseStartTime = Time.time;
        canPressNote = true;
    }
}

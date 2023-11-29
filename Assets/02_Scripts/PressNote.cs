using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressNote : MonoBehaviour
{
    public bool canPressNote = false;    // ��Ʈ�� ���� �� �ִ��� ����
    private float noteReleaseStartTime;    // ��Ʈ�� �� ���� �ð�
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
        // ��Ʈ�� ���� �� �ִ� ���¿��� ���콺 ���� ��ư�� �������� ��
        if (canPressNote && Input.GetMouseButtonUp(0))
        {
            releaseDuration = Time.time - noteReleaseStartTime;
            
            if (releaseDuration <= 0.2f)
            {
                // �ʹ� ���� ������
                Debug.LogWarning("�ʹ� ���� ��Ʈ�� �ý��ϴ�!--------------");
                GameManager.Instance.missCount++;

            }
            // ��Ʈ�� ���µ� 0.4�� �̳��� "������ Ÿ�̹�"���� ����
            if (releaseDuration > 0.2f && releaseDuration <= 0.6f)
            {
                // ������ Ÿ�ֿ̹� ��Ʈ�� ���� ���� ó��
                Debug.LogWarning("������ Ÿ�̹����� ��Ʈ�� �ý��ϴ�!");

                // ���⿡ ���� ���� ���� ó���� �߰��� �� �ֽ��ϴ�.
            }
            if (releaseDuration > 0.6f)
            {
                // �ʹ� ������ ������
                Debug.LogWarning("-------- ������ ��Ʈ�� �߿��������ϵ��.");
                GameManager.Instance.missCount++;

            }
            Debug.Log(noteReleaseStartTime);

            Debug.Log("����׿�");
            Debug.Log(releaseDuration);
            // ���� �ʱ�ȭ
            canPressNote = false;
        }
    }

    // ��Ʈ�� ���� �� �ִ��� ���θ� �����ϴ� �Լ�
    public void SetCanPressNote()
    {
        noteReleaseStartTime = Time.time;
        canPressNote = true;
    }
}

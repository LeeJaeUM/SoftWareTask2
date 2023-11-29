using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    // ������� ����
    public AudioClip backgroundMusic;

    // AudioSource ������Ʈ
    private AudioSource audioSource;

    public GameEndUI gameEndUI;
    void Start()
    {
        // AudioSource ������Ʈ �߰�
        audioSource = gameObject.AddComponent<AudioSource>();

        // ������� ���� ����
        audioSource.clip = backgroundMusic;

        // �ݺ� ��� ���� (optional)
        audioSource.loop = false;

        // ������� ���
        audioSource.PlayOneShot(backgroundMusic);

        // ��� ���� �� count �� ����
        Invoke("AfterMusicEnd", backgroundMusic.length);
    }

    void AfterMusicEnd()
    {
        GameManager.Instance.EndGame();
        gameEndUI.ToggleUIObjects();
    }
}

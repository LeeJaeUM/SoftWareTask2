using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    // 배경음악 파일
    public AudioClip backgroundMusic;

    // AudioSource 컴포넌트
    private AudioSource audioSource;

    public GameEndUI gameEndUI;
    void Start()
    {
        // AudioSource 컴포넌트 추가
        audioSource = gameObject.AddComponent<AudioSource>();

        // 배경음악 파일 설정
        audioSource.clip = backgroundMusic;

        // 반복 재생 설정 (optional)
        audioSource.loop = false;

        // 배경음악 재생
        audioSource.PlayOneShot(backgroundMusic);

        // 재생 종료 후 count 값 증가
        Invoke("AfterMusicEnd", backgroundMusic.length);
    }

    void AfterMusicEnd()
    {
        GameManager.Instance.EndGame();
        gameEndUI.ToggleUIObjects();
    }
}

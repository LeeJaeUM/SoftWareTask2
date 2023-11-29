using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public string mainGameSceneName = "MainGame";
    public string titleSceneName = "Title";
    public bool gameEnd = false; // gameEnd 변수 추가
    public int missCount = 0;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GameManager").AddComponent<GameManager>();
                DontDestroyOnLoad(instance.gameObject);
            }
            return instance;
        }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        // TODO: 게임 시작 시 초기화할 내용이 있다면 여기에 추가하세요.
    }

    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene(mainGameSceneName);
    }
    public void OnTitleButtonClicked()
    {
        SceneManager.LoadScene(titleSceneName);
    }

    public void OnExitButtonClicked()
    {
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    // 게임 종료 함수
    public void EndGame()
    {
        gameEnd = true;
        Debug.Log("Game Ended!");
    }
}

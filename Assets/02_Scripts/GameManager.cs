using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public string mainGameSceneName = "MainGame";
    public string titleSceneName = "Title";
    public bool gameEnd = false; // gameEnd ���� �߰�
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
        // TODO: ���� ���� �� �ʱ�ȭ�� ������ �ִٸ� ���⿡ �߰��ϼ���.
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

    // ���� ���� �Լ�
    public void EndGame()
    {
        gameEnd = true;
        Debug.Log("Game Ended!");
    }
}

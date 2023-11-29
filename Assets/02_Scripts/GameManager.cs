using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public string mainGameSceneName = "MainGame";
    public string titleSceneName = "Title";
    public bool gameEnd = false;
    public int goodCount = 0;
    public int missCount = 0;
    public float milisec = 0;

    public Text missCountText; // Reference to the Text component for missCount
    public Text goodCountText;
    public Text milisecText;

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
        // Find the Text component in the scene
        missCountText = GameObject.Find("MissCountText").GetComponent<Text>();
        goodCountText = GameObject.Find("GoodCountText").GetComponent<Text>();
        milisecText = GameObject.Find("milisecCountText").GetComponent<Text>();
    }

    void Update()
    {
        // Update the missCountText in real-time
        if (missCountText != null)
        {
            missCountText.text = "Miss Count: " + missCount;
        }
        if (goodCountText != null)
        {
            goodCountText.text = "Good Count: " + goodCount;
        }
        if (milisecText != null)
        {
            milisecText.text = "JustTime : \n" + milisec;
        }
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

    public void EndGame()
    {
        gameEnd = true;
        Debug.Log("Game Ended!");
    }
}

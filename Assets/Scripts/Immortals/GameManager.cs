using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public enum GameState
{
    Starting,
    Playing,
    Paused,
    GameOver,
    LevelCompleted
}

public class GameManager : MonoBehaviour
{
    public GameState State;
    public LevelManager LevelManager;
    public MainCanvas MainCanvas;
    public List<UnityAction> initializers = new();

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        DOTween.Init();
        Reset();
        Initialize();
    }

    private void Initialize()
    {
        initializers.Add(MainCanvas.Initialize);
        initializers.Add(LevelManager.Initialize);

        StartCoroutine(InitializeCor());

        IEnumerator InitializeCor()
        {
            MainCanvas.ShowLoadingScreen();

            for (int i = 0; i < initializers.Count; i++)
            {
                initializers[0]?.Invoke();
                yield return new WaitForSecondsRealtime(1f);
            }

            MainCanvas.HideLoadingScreen();
        }
    }

    public void Reset()
    {
        State = GameState.Starting;
    }

    public void Play()
    {
        State = GameState.Playing;
    }

    public void Pause()
    {
        State = GameState.Paused;
    }

    public void GameOver()
    {
        State = GameState.GameOver;
    }

    public void LevelCompleted()
    {
        State = GameState.LevelCompleted;
    }
}

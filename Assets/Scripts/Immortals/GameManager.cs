// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
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

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        DOTween.Init();
        Reset();
    }

    public void Reset()
    {
        State = GameState.Starting;
        MainCanvas.Initialize(this);
        LevelManager.Initialize(this);
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

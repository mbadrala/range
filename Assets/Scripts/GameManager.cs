using System.Collections;
using System.Collections.Generic;
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

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        DOTween.Init(); 
    }

    public void Reset()
    {
        State = GameState.Starting;
        LevelManager.Initialize();
    }

    public void StartGame()
    {
    }
}

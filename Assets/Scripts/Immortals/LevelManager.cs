using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private GameManager gm;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void Initialize(GameManager gm)
    {
        this.gm = gm;
    }
}

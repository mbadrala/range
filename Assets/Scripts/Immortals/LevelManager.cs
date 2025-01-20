using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void Initialize()
    {
    }
}

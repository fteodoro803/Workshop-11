using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int Score { get; private set; }

    private void Awake()
    {
        //Debug.Assert(Instance==null);
        if (Instance != null)
        {
            Destroy(gameObject);
            Debug.LogError("Multiple Game Managers");
            return;
        }
        
        Instance = this;
    }

    public void AddScore(int add)
    {
        Score += add;
    }
}

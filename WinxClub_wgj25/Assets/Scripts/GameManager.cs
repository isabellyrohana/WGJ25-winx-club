using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int CollectableCount { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        
        DontDestroyOnLoad(gameObject);
    }
    
    private void Start()
    {
        CollectableCount = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Itens Quantitiy {CollectableCount}");
        }
    }

    public void IncreaseCollectableCount()
    {
        CollectableCount++;
    }
    
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int CollectableCount { get; private set; }

    [SerializeField] PlayerMovement caprichosoMovement;
    [SerializeField] private Image finishImage;

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

        if (CollectableCount >= 2)
        {
            ShowEndGame();
        }
    }

    public void IncreaseCollectableCount()
    {
        CollectableCount++;
    }
    
    private void ShowEndGame()
    {
        finishImage.gameObject.SetActive(true);
        caprichosoMovement.StopPlayerMovement();
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int CollectableCount { get; private set; }

    [SerializeField] PlayerMovement caprichosoMovement;

    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private Button backButton;
    
    private int feathersCount;

    private bool hasGameEnded;
    
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
    }
    
    private void Start()
    {
        feathersCount = 3;
        CollectableCount = 0;
        canvasGroup.alpha = 0;
        hasGameEnded = false;
        backButton.onClick.AddListener(OnClickBackButton);
    }

    private void OnClickBackButton()
    {
        ResetGame();
        SceneController.Instance.LoadPreviousScene();
    }

    private void ResetGame()
    {
        CollectableCount = 0;
        canvasGroup.alpha = 0;
        hasGameEnded = false;
    }

    private void Update()
    {
        // TODO: REMOVE THIS IS FOR TEST
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Itens Quantitiy {CollectableCount}");
        }
    }

    public void IncreaseCollectableCount()
    {
        CollectableCount++;

        if (CollectableCount < feathersCount || hasGameEnded) return;
        hasGameEnded = true;
        ShowEndGame();

    }
    
    private void ShowEndGame()
    {
        canvasGroup.alpha = 1;
        caprichosoMovement.StopPlayerMovement();
    }
    
    public void RegisterFeather(ICollectable collectable)
    {
        collectable.OnCollected += IncreaseCollectableCount;
    }
}

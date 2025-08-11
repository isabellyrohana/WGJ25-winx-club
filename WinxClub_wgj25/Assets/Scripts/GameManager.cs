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

    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private Button backButton;

    private bool hasGameEnded = false;
    
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
        canvasGroup.alpha = 0;
        backButton.onClick.AddListener(OnClickBackButton);
    }

    private void OnClickBackButton()
    {
        SceneController.Instance.LoadPreviousScene();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"Itens Quantitiy {CollectableCount}");
        }

        if (CollectableCount >= 2 && !hasGameEnded)
        {
            hasGameEnded = true;
            ShowEndGame();
        }
    }

    public void IncreaseCollectableCount()
    {
        CollectableCount++;
    }
    
    private void ShowEndGame()
    {
        canvasGroup.alpha = 1;
        caprichosoMovement.StopPlayerMovement();
    }
}

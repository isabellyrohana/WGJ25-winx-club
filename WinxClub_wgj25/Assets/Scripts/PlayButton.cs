using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private Button playButton;
    
    private void Start()
    {
        playButton.onClick.AddListener(OnClickPlayButton);
    }

    private void OnClickPlayButton()
    {
        SceneController.Instance.LoadNextScene();
    }
}

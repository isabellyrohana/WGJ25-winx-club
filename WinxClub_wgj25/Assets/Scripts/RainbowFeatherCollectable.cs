using System;
using DefaultNamespace;
using UnityEngine;

public class RainbowFeatherCollectable : MonoBehaviour, ICollectable
{
    public event Action OnCollected;

    private void Start()
    {
        GameManager.Instance.RegisterFeather(this);
    }
    
    public bool CanCollect(Collider other)
    {
        return other.CompareTag("Caprichoso") || other.CompareTag("Garantido");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (!CanCollect(other)) return;
        Debug.Log("Rainbow Feather Collectable");
        gameObject.SetActive(false);
        OnCollected?.Invoke();
    }
}
using System;
using DefaultNamespace;
using UnityEngine;

public class BlueFeatherCollectable : MonoBehaviour, ICollectable
{
    public event Action OnCollected;

    private void Start()
    {
        GameManager.Instance.RegisterFeather(this);
    }
    
    public bool CanCollect(Collider other)
    {
        return other.CompareTag("Garantido");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (!CanCollect(other)) return;
        Debug.Log("Blue Feather Collectable");
        gameObject.SetActive(false);
        OnCollected?.Invoke();
    }
}
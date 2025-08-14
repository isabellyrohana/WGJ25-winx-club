using System;
using DefaultNamespace;
using Unity.VisualScripting;
using UnityEngine;

public class RedFeatherCollectable : MonoBehaviour, ICollectable
{
    public event Action OnCollected;

    private void Start()
    {
        GameManager.Instance.RegisterFeather(this);
    }
    
    public bool CanCollect(Collider other)
    {
        return other.CompareTag("Caprichoso");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (!CanCollect(other)) return;
        Debug.Log("Red Feather Collectable");
        gameObject.SetActive(false);
        OnCollected?.Invoke();
    }
}

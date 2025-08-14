using DefaultNamespace;
using UnityEngine;

public class BlueFeatherCollectable : MonoBehaviour, ICollectable
{
    public bool CanCollect(Collider other)
    {
        return other.CompareTag("Garantido");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (!CanCollect(other)) return;
        Debug.Log("Blue Feather Collectable");
        GameManager.Instance.IncreaseCollectableCount();
        gameObject.SetActive(false);
    }
}
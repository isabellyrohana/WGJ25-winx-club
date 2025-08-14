using DefaultNamespace;
using UnityEngine;

public class RainbowFeatherCollectable : MonoBehaviour, ICollectable
{
    public bool CanCollect(Collider other)
    {
        return other.CompareTag("Caprichoso") || other.CompareTag("Garantido");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (!CanCollect(other)) return;
        Debug.Log("Rainbow Feather Collectable");
        GameManager.Instance.IncreaseCollectableCount();
        gameObject.SetActive(false);
    }
}
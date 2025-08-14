using DefaultNamespace;
using UnityEngine;

public class RedFeatherCollectable : MonoBehaviour, ICollectable
{
    public bool CanCollect(Collider other)
    {
        return other.CompareTag("Caprichoso");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (!CanCollect(other)) return;
        Debug.Log("Red Feather Collectable");
        GameManager.Instance.IncreaseCollectableCount();
        gameObject.SetActive(false);
    }
}

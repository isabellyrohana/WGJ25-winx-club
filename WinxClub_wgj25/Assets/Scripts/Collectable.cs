using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Caprichoso") || other.CompareTag("Garantido"))
        {
            Debug.Log("Collected");
            GameManager.Instance.IncreaseCollectableCount();
            gameObject.SetActive(false);
        }
    }
}
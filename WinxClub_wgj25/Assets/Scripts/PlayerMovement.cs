using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody garantidoRigidbody;
    [SerializeField] private Rigidbody caprichosoRigidbody;
    
    [SerializeField] private float moveSpeed = 1.0f;
    
    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        
        Vector3 move = new Vector3(horizontalMovement, 0f, 0f) * (moveSpeed * Time.fixedDeltaTime);
        garantidoRigidbody.MovePosition(garantidoRigidbody.position + move);
        caprichosoRigidbody.MovePosition(caprichosoRigidbody.position - move);
    }
}

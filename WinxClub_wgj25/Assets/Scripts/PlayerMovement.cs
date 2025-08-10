using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody garantidoRigidbody;
    [SerializeField] private Rigidbody caprichosoRigidbody;
    
    [SerializeField] private float moveSpeed = 1.0f;
    
    [SerializeField] private SpriteRenderer caprichosoSprite;
    [SerializeField] private SpriteRenderer garantidoSprite;

    private void Start()
    {
        caprichosoSprite.flipX = true;
    }

    private void FixedUpdate()
    {
        var horizontalMovement = Input.GetAxis("Horizontal");
        
        var move = new Vector3(horizontalMovement, 0f, 0f) * (moveSpeed * Time.fixedDeltaTime);
        garantidoRigidbody.MovePosition(garantidoRigidbody.position + move);
        caprichosoRigidbody.MovePosition(caprichosoRigidbody.position - move);
        
        FlipSprite(horizontalMovement);
    }

    private void FlipSprite(float horizontalMovement)
    {
        if (horizontalMovement > 0)
        {
            caprichosoSprite.flipX = true;
            garantidoSprite.flipX = false;
        }
        else if (horizontalMovement < 0)
        {
            caprichosoSprite.flipX = false;
            garantidoSprite.flipX = true;
        }
    }
}

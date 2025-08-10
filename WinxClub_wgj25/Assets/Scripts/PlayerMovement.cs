using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody garantidoRigidbody;
    [SerializeField] private Rigidbody caprichosoRigidbody;
    
    void FixedUpdate()
    {
        garantidoRigidbody.velocity = new Vector2(-Input.GetAxis("Horizontal"), 0);
        caprichosoRigidbody.velocity = new Vector2(Input.GetAxis("Horizontal"), 0);
    }
}

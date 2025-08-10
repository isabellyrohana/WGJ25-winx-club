using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rigidbody;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}

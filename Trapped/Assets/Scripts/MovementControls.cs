using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class MovementControls : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void JustMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    void Update()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

  
}

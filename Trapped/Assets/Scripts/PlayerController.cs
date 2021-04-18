using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 5.0f;

    private Rigidbody2D playerRB;

    private float HorizontalInput;
    private float VerticalInput;

    private Vector2 moveDirection;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerRB = GetComponent<Rigidbody2D>();
        movement();
    }

    void movement()
    {
        //call for the movement
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        moveDirection = new Vector2(HorizontalInput, VerticalInput).normalized;

        //movement
        playerRB.velocity = new Vector2(moveDirection.x * movespeed, moveDirection.y * movespeed);

        //playerRB.MovePosition(Vector2.up * movespeed * VerticalInput * Time.fixedDeltaTime);
        //playerRB.MovePosition(Vector2.right * movespeed * HorizontalInput * Time.fixedDeltaTime);



    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 10.0f;

    private Rigidbody2D playerRB;

    private float HorizontalInput;
    private float VerticalInput;

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

        if(HorizontalInput != 0 || VerticalInput != 0) // prevents from sliding
        {
            playerRB.AddForce(Vector2.up * movespeed * VerticalInput);
            playerRB.AddForce(Vector2.right * movespeed * HorizontalInput);
        }
        else { playerRB.velocity = Vector2.zero;}



        Debug.Log(HorizontalInput);
    }
}

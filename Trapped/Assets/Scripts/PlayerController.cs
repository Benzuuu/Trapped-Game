using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 5.0f;
    private GameManager gameManager;
    public Animator animator;

    private Rigidbody2D playerRB;

    private float HorizontalInput;
    private float VerticalInput;

    private Vector2 moveDirection;

    public bool InPuzzle;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (InPuzzle == false)
        {
            movement();
        }
    }

    void movement()
    {
        //call for the movement
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        animator.SetFloat("Speed Horizontal", HorizontalInput);// Horizontal Movement
        animator.SetFloat("Speed Vertical", VerticalInput);// Vertical Movement

        moveDirection = new Vector2(HorizontalInput, VerticalInput).normalized;

        //movement
        playerRB.velocity = new Vector2(moveDirection.x * movespeed, moveDirection.y * movespeed);

        //playerRB.MovePosition(Vector2.up * movespeed * VerticalInput * Time.fixedDeltaTime);
        //playerRB.MovePosition(Vector2.right * movespeed * HorizontalInput * Time.fixedDeltaTime);

    }

    private void OnCollisionEnter2D(Collision2D Other)
    {
        if (Other.gameObject.CompareTag("Enemy"))
        {
            gameManager.GameOver();
            Debug.Log("Reseted");
        }
    }
}

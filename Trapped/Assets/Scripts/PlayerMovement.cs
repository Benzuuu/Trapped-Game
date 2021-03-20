using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //speed of the character
    public float speed = 10.0f;

    //variable for the Input
    private float HorizontalInput;
    private float VerticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetAxis
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        //Move Vertically
        transform.Translate(Vector2.up * Time.deltaTime * speed * VerticalInput);
        //Move Horizontally
        transform.Translate(Vector2.right * Time.deltaTime * speed * HorizontalInput);

        
    }
}

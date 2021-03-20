using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 10.0f;

    private float HorizontalInput;
    private float VerticalInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement();


    }

    void movement()
    {
        //call for the movement
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        //assign them to translation
        transform.Translate(Vector2.up * movespeed * Time.deltaTime * VerticalInput);
        transform.Translate(Vector2.right * movespeed * Time.deltaTime * HorizontalInput);
    }
}

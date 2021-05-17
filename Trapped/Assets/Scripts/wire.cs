using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wire : MonoBehaviour
{
    public SpriteRenderer wireEnd;
    public GameObject lightOn;

    Vector2 startPoint;
    Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPoint = transform.parent.position;
        startPosition = transform.position;
    }

    // Update is called once per frame
    private void OnMouseDrag()
    {
        //mouse position to world point
        Vector2 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // check for nearby connection points
        Collider2D[] colliders = Physics2D.OverlapCircleAll(newPosition, .2f);
        foreach (Collider2D collider in colliders)
        {
            //make sure not my own collider
            if(collider.gameObject != gameObject)
            {
                //update wire to the connection point position
                UpdateWire(collider.transform.position);

                //checks if same color
                if(transform.parent.name.Equals(collider.transform.parent.name))
                {
                    //finish step
                    collider.GetComponent<wire>()?.Done();
                    Done();
                }

                //
                return;
            }
        }
        

        //update wire
        UpdateWire(newPosition);

    }

    void Done()
    {
        //turn on the Light
        lightOn.SetActive(true);

        Destroy(this);
    }

    private void OnMouseUp()
    {
        //reset wire position
        UpdateWire(startPosition);
    }

    void UpdateWire(Vector2 newPosition)
    {
        //update position
        transform.position = newPosition;

        //update direction
        Vector2 direction = newPosition - startPoint;
        transform.right = direction * transform.lossyScale.x;

        //update scale
        float dist = Vector2.Distance(startPoint, newPosition);
        wireEnd.size = new Vector2(dist, wireEnd.size.y);
    }
}

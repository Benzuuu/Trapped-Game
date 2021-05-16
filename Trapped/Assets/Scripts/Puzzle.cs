using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Puzzle : MonoBehaviour
{
    public GameObject PuzzleCanvas;
    private PlayerController player;// Name of the Script and what to name it when called

    public bool PuzzleActive;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && PuzzleActive)
        {
            if (PuzzleCanvas.activeInHierarchy)//checks if active in heirch, will close if yes. if e is pressed again
            {
                PuzzleCanvas.SetActive(false);
                player.InPuzzle = false;
            }
            else
            {
                player.InPuzzle = true;
                PuzzleCanvas.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            PuzzleActive = true;
            Debug.Log("I am Working");
        }
    }

    private void OnTriggerExit2D(Collider2D Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            PuzzleActive = false;
            Debug.Log("I am Not Working");
        }

    }
}

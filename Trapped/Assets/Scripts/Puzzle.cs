using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Puzzle : MonoBehaviour
{
    public GameObject PuzzleCanvas;
    private PlayerController player;

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
            if (PuzzleCanvas.activeInHierarchy)
            {
                PuzzleCanvas.SetActive(false);
                player.InPuzzle = false;
            }
            else
            {
                PuzzleCanvas.SetActive(true);
                player.InPuzzle = true;
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
            player.InPuzzle = false;
            PuzzleCanvas.SetActive(false);
            PuzzleActive = false;
            Debug.Log("I am Not Working");
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteTrigger : MonoBehaviour
{
    public GameObject dialogBox;
    public GameObject Note;
    public Text dialogText;
    public string dialog;

    public bool dialogActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && dialogActive) // on button click if dialogActive is true
        {
            if(dialogBox.activeInHierarchy)//checks if the DialogBox is active in the Heirch, if yes then it sets them as inactive on button click
            {
                dialogBox.SetActive(false);
                Note.SetActive(false);
            }
            else 
            {
                dialogBox.SetActive(true);
                Note.SetActive(true);
                dialogText.text = dialog; // Sets Dialog to Whatever is in the Dialog 
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            dialogActive = true;  //sets as true if player is within range
            Debug.Log("I am Working");
        }
    }

    private void OnTriggerExit2D(Collider2D Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            dialogActive = false; //sets as false if player is not within range
            dialogBox.SetActive(false);
            Note.SetActive(false);
            Debug.Log("I am Not Working");
        }
            
    }
}

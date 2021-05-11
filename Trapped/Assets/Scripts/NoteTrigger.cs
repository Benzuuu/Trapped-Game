using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteTrigger : MonoBehaviour
{
    public GameObject dialogBox;
    public GameObject Note;
    public GameObject Image;
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
        if(Input.GetKey(KeyCode.E) && dialogActive)
        {
            if(dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
                Note.SetActive(false);
                Image.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
                Image.SetActive(true);
                Note.SetActive(true);
                dialogText.text = dialog; // Sets Dialog to Whatever is in the Dialog 
            }
        }
        
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            dialogActive = true;
            Debug.Log("I am Working");
        }
    }

    private void OnTriggerExit2D(Collider2D Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            dialogActive = false;
            dialogBox.SetActive(false);
            Note.SetActive(false);
            Image.SetActive(false);
            Debug.Log("I am Not Working");
        }
            
    }
}

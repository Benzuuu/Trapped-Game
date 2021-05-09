using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteTrigger : MonoBehaviour
{
    public GameObject dialogBox;
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
        if(Input.GetKey(KeyCode.Space) && dialogActive)
        {
            if(dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else
            {
                dialogBox.SetActive(true);
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

    private void OnTriggerExit2d(Collider2D Other)
    {
        if(Other.gameObject.CompareTag("Player"))
        {
            dialogActive = false;
            Debug.Log("I am Not Working");
        }
    }
}

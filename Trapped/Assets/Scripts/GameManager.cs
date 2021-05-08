using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to be able interact with and manage with our scenes in our scene folder
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //checks if game is active
    public bool isGameActive;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {

        isGameActive = false;
        //to be able to load the scene again ( Plays the active Scene)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//to be able interact with and manage with our scenes in our scene folder
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //checks if game is active
    public bool isGameActive;
    public GameObject GateOpen;
    public GameObject Lights;
    public GameObject Wire;
    private int wiringCount = 0;

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

    public void Wiring(int Count)
    {
        wiringCount = wiringCount + Count;
        Debug.Log(Count);
        if(wiringCount == 8) // number of wires
        {
            Debug.Log("Nice");
            GateOpen.SetActive(false);
            Lights.SetActive(true);
            Wire.SetActive(false);
        }

    }
}

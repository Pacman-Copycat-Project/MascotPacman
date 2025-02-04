using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    private int scoreCount = 0;
    public PacMan pac;

    public Button StartBut;
    public Button QuitBut;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Camera 2").GetComponent<Camera>().enabled = false;
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
           Debug.Log("C was pressed");
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void UpScore()
    {
        scoreCount++;
        scoreText.text = "Score:  " + scoreCount;
    }
    public void StartGame()
    {
            Debug.Log("Start!");
            SceneManager.LoadScene("Level1");
    }
    public void QtGame()
    {
        Application.Quit();
    }
    
}

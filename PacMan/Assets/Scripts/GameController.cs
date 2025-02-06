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
    public GameObject winScreen;
    public GameObject GameOverScreen;
     public AudioSource audioSource;
     public AudioClip WinMusic;
     public AudioClip LoseMusic;
     public AudioClip StartMusic;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Find("Camera 2").GetComponent<Camera>().enabled = false;
        scoreText.text = "Score: 0";
        winScreen.SetActive(false);
        GameOverScreen.SetActive(false);
        audioSource.PlayOneShot(StartMusic);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void UpScore()
    {
        scoreCount++;
        scoreText.text = "Score:  " + scoreCount;
        if (scoreCount > 3 && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
            Destroy(pac);
            audioSource.PlayOneShot(WinMusic);
            SceneManager.LoadScene("Level2");
        } else if (scoreCount > 10) 
        {
            Destroy(pac);
            winScreen.SetActive(true);
            audioSource.PlayOneShot(WinMusic);
        }
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

    public void GameOver()
    {
        audioSource.PlayOneShot(LoseMusic);
        GameOverScreen.SetActive(true);
    }
      
}

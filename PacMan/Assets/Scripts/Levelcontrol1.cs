using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levelcontrol1 : MonoBehaviour{

public int index;
public string levelName;


  
    void onTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("testing");
            SceneManager.LoadScene(index);
            SceneManager.LoadScene(levelName);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Room1exit : MonoBehaviour
{

public string scenename;

      void OnTriggerEnter2D(Collider2D other)
    {
        PacMan controller = other.GetComponent<PacMan>();

        if (controller != null)
        {
            Debug.Log("weeeee");
            SceneManager.LoadScene(scenename);
        }
}
}

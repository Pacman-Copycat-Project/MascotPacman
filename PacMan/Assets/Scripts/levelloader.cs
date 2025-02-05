using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onTriggerEnter(Collider2D other)
    {
        if (other.CompareTag("roomexit1"))
        {
                SceneManager.LoadScene(2);
                Debug.Log("testy");
        }
    }
}

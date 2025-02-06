using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public GameController gameCon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerEnter2D(Collider2D other)
    {
        PacMan controller = other.GetComponent<PacMan>();

        if (controller != null)
        {
            Destroy(gameObject);
            gameCon.UpScore();
            /*if (controller.health < controller.maxHealth)
            {
                
                //controller.ChangeHealth(1);
                //controller.PlaySound(collectedClip);
                
            }*/
        }

    }
}

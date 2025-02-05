using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    [SerializeField] int direction = 1;
    [SerializeField] int speed = 1;
    public bool vertical = false;
    Vector2 lookDirection = new Vector2(1, 0);

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
            RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position + Vector2.up * 0.2f, lookDirection, 1.5f, LayerMask.GetMask("Walls"));
            if (hit.collider != null)
            {
                //Debug.Log("Hit something else");
                WallsController character = hit.collider.GetComponent<WallsController>();
                if (character != null)
                {
                    //Debug.Log("Hit something");
                    vertical = !vertical;
                }
            }
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
        }

        GetComponent<Rigidbody2D>().MovePosition(position);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        PacMan controller = other.GetComponent<PacMan>();
        

        if (controller != null)
        {
            Destroy(controller);
            Destroy(gameObject);
            //controller.currentScore();
            /*if (controller.health < controller.maxHealth)
            {
                
                //controller.ChangeHealth(1);
                //controller.PlaySound(collectedClip);
                
            }*/
        }
    }
}

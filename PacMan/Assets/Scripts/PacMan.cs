using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;


public class PacMan : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    private float horizontal;
    private float vertical;
    public float speed = 6.0f;
    public int score = 0;
    Vector2 lookDirection = new Vector2(1, 0);

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        rigidbody2d.velocity = new Vector2(horizontal, vertical);
        
        
        Vector2 move = new Vector2(horizontal, vertical);
        lookDirection.Set(move.x, move.y);
        lookDirection.Normalize();
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
  
    }

    public void currentScore()
    {
        score++;
    }

    public void peace()
    {
        Debug.Log("peace activated");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pellet")
        {
            Destroy(collision.gameObject);
            GameObject.Find("Game Controller").GetComponent<GameController>().UpScore();
        }
    }

}

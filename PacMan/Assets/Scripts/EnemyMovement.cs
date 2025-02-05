using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    private Vector2 direction = Vector2.right;
    [SerializeField] int speed = 1;
    public float rayLength = 0.5f;
    public bool vertical = false;
    Vector2 lookDirection = new Vector2(1, 0);
    private Vector2 formerDir;
    

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        //Debug.Log(direction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //Move();
        RaycastHit2D hit = Physics2D.Raycast(rigidbody2d.position, direction, rayLength, LayerMask.GetMask("Walls"));
        Debug.DrawRay(rigidbody2d.position, direction * rayLength, Color.red);
    if (hit.collider == null) // No wall ahead
    {
        Move();
    }
    else
    {
        direction = GetNewDirection(); // Change direction before hitting the wall
    }
    }
    void Move()
        {
            Vector2 nextPosition = rigidbody2d.position + direction *speed * Time.fixedDeltaTime;
            rigidbody2d.MovePosition(nextPosition);
        }
    
    Vector2 GetNewDirection()
    {
        // Try a new direction (up, down, left, right)
        List<Vector2> possibleDirections = new List<Vector2>{ Vector2.up, Vector2.down, Vector2.left, Vector2.right };
    
for (int i = 2 ; i > 0; i--)
        {
            Debug.Log(possibleDirections.Count);
            if (possibleDirections[i] == direction )
            {
                Debug.Log("I is: " + i + " and list is:  " + possibleDirections[i]);
                possibleDirections.RemoveAt(i);
                 Debug.Log("I is: " + i + " and list is:  " + possibleDirections[i]);
                break; // Exit loop once a match is found
            }
        }

        
        int currentIndex = Random.Range(0, possibleDirections.Count);
        //Debug.Log(possibleDirections.Count);
        Vector2 dir = possibleDirections[currentIndex];
        //Debug.Log("current direction is " + direction + "new direction is " + dir);
        //Debug.Log("New direction found");
        formerDir = direction;
        return dir;
    }
    
            
            
        //return Vector2.up; // If all else fails, go backward


    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*
        if (collision.gameObject.CompareTag("Walls")) // Ensure walls have the correct tag!
        {

                //Destroy(collision.gameObject);
                //Debug.Log(rigidbody2d.position);
                //rigidbody2d.MovePosition(direction * speed * 3);
                //Debug.Log(rigidbody2d.position);
                direction = GetNewDirection();
                Debug.Log(direction);
                
                Debug.Log("hit the wall");
            // GameObject.Find("Game Controller").GetComponent<GameController>().UpScore();
            */
            }
}

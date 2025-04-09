using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    public float jumpForce = 10;
    public int health = 99;
    public int lives = 1;
    public Transform respawnObj;

    private new Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerJump();
    }




    /// <summary>
    /// Check for input to move the player left or right
    /// </summary>
    private void PlayerMove()
    {
        // Check if D or Right Arrow keys are held 
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //transform.position += Vector3.right * speed * Time.deltaTime;

            rigidbody.MovePosition(transform.position + (Vector3.right * speed * Time.deltaTime));
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        // Check if A or Left Arrow keys are held 
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.position += Vector3.left * speed * Time.deltaTime;

            rigidbody.MovePosition(transform.position + (Vector3.left * speed * Time.deltaTime));
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    /// <summary>
    /// Allows the player to jump using the spacebar key if it is touching the ground.
    /// </summary>
    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnGround())
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }

    /// <summary>
    /// Performs a raycast downwards from the player and returns true if it hits the ground
    /// ie: Returns true if the player is on the ground.
    /// </summary>
    /// <returns></returns>
    private bool OnGround()
    {
        bool onGround = false;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1.2f))
        {
            
            onGround = true;
        }

        return onGround;
    }

    /// <summary>
    /// Reduces player lives by 1 and respawns the player.
    /// </summary>
    public void LoseLife()
    {
        //Have player lose a life
        lives--;
        //Check if player has zero lives
        if (lives == 0)
        {
            //if 0 - game over
            SceneManager.LoadScene(2);
            print("Game Over");
        }
    }

}

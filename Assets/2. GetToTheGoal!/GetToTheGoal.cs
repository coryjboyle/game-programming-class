using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Don't forget you can check all the different code available in the Unity Editor by checking their API.
// An API is a list of all the different classes, methods, and variables that you can use in a software package like Unity.
// Unity's API can be found here:
// https://docs.unity3d.com/ScriptReference/

public class GetToTheGoal : MonoBehaviour
{
    public GameObject playerGameObject;
    public Collider goalCollider;
    public GameObject youWinPrefab;
    
    private CharacterController characterController;
    private Collider playerCollider;
    private GameObject youWinInstance;
    
    //Sometimes it's useful to have a space between variables and functions.
    [Space(10)]
    
    // Variables for player movement. These are public so we can see and change them in the Unity Editor.
    public float moveSpeed = 5.0f;
    public float jumpForce = 5.0f;
    public float gravity = 9.8f;

    private Vector3 playerStartingPosition;
    private Vector3 moveDirection = Vector3.zero;
    private bool win = false;
    
    // Start is called before the first frame update
    private void Start()
    {
        // Set the player's starting position to the current position of the playerGameObject.
        playerStartingPosition = playerGameObject.transform.position;
        
        // Create a new CharacterController component and add it to the playerGameObject.
        // This is really useful built-in script for moving the player around and checking for collisions.
        characterController = playerGameObject.AddComponent<CharacterController>();
        
        // Get the Collider component from the playerGameObject.
        // A Collider is a shape that is used to detect collisions with other objects.
        playerCollider = playerGameObject.GetComponent<Collider>();
    }

    
    // Update runs once every frame.
    // If your game is running at 60 frames per second, this will run 60 times per second.
    private void Update()
    {
        // If the player presses the "R" key, reset the game.
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Resetting the game...");
            
            // Run our Reset method to set everything back to the starting position.
            Reset();
            // Return is a really handy keyword that stops the method from running any more code.
            return;
        }
        
        // Check if the player is on the ground.
        if (characterController.isGrounded)
        {
            // Since we are on the ground, we can move left and right.
            // GetAxis("Horizontal") returns a value between -1 and 1 based on the player's input.
            // This can be the arrow keys, WASD, or a controller stick.
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
            moveDirection *= moveSpeed;

            // Check if the player wants to jump
            // By default, the jump button is the space bar.
            if (Input.GetButton("Jump"))
            {
                // Set the y value (up and down) of our moveDirection to the jumpForce
                // This will make the player move upwards like they're jumping.
                moveDirection.y = jumpForce;
            }
        }

        // Check if the player's Collider shape is inside of the goal's Collider shape.
        // The collider on the Goal gameObject is set to "Is Trigger" so that the player can pass through it.
        if (playerCollider.bounds.Intersects(goalCollider.bounds))
        {
            // Here we use a boolean value (true or false) to check if the player has already won.
            // This way, we only show the "You win!" message once.
            if (win == false)
            {
                Debug.Log("You win!");
                // Create our "You win!" message gameobject
                // Instantiate creates a new copy of the youWinPrefab at the player's position.
                // Save a reference to the new gameobject so we can delete it in Reset.
                youWinInstance = Instantiate(youWinPrefab);
                
                // Set the win variable to true so we don't show the message again.
                win = true;
            }
        }
        
        // Decrease the y value of moveDirection by our gravity every frame to slowly bring the player down.
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the player
        characterController.Move(moveDirection * Time.deltaTime);
    }

    //Here, let's make a method to reset the game by manually setting the values back to their starting positions.
    private void Reset()
    {
        // Disable the CharacterController so we can move the player without it interfering.
        characterController.enabled = false;
        // Set the player's position back to the starting position.
        playerGameObject.transform.position = playerStartingPosition;
        // Enable the CharacterController again so the player can move.
        characterController.enabled = true;
        
        
        moveDirection = Vector3.zero;
        
        if (youWinInstance)
        {
            // Deletes our copy of the "You win!" message.
            Destroy(youWinInstance);
        }
        win = false;
    }
}

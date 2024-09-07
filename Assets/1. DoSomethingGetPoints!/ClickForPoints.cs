using TMPro;
using UnityEngine;

public class ClickForPoints : MonoBehaviour
{
    // These are our variables! They are references to numbers, or objects in our scene.
    // By adding the public keyword to the variable, it tells Unity to show it in the game inspector.
    // We can then change the value directly in Unity, even when the game is running!
    public int pointsPerClick;
    public TextMeshPro pointCounter;
    
    // This variable is private which tells Unity to not let other scripts change the value
    private int currentPoints;
    
    // Start runs once when the game first starts.
    // Use this to do setup on your objects.
    void Start()
    {
        // Set the current points to 0
        currentPoints = 0;
        // Update the point counter text.
        // Text uses a value type called a "string". To make a string, put words in quotation marks.
        // Strings are important because they tell the compiler that our object is a collection of words
        // and not a variable called Points: .
        pointCounter.text = "Points: " + currentPoints;
    }

    // The cube has a component called EventTrigger attached to it.
    // The EventTrigger runs this code every time the mouse clicks down on it.
    // (In order for EventTrigger to work, the camera has to have a PhysicsRaycaster component on it)
    public void ClickEvent()
    {
        // Add the pointsPerClick value to our current points.
        // The += operator will add pointsPerClick to current points and update it.
        // Otherwise, you would have to write it like:
        // currentPoints = currentPoints + pointsPerClick;
        currentPoints += pointsPerClick;
        
        // Update the text with our new point total
        pointCounter.text = "Points: " + currentPoints;
    }
}

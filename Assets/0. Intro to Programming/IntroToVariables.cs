using UnityEngine;

// This script is a brief introduction to variables in C# :)
public class IntroToVariables : MonoBehaviour
{
    // Variables are like containers that store values for our program to use!
    // There are many types of variables, but these are the most common:
    
    // An integer is a whole number (no decimal point)
    int myIntVariable = 0;
    
    // A float is a number with a decimal point
    float myFloatVariable = 0.0f;
    
    // A string is a collection of characters (letters, numbers, symbols)
    string myStringVariable = "Hello World!";
    
    // A boolean is a true or false value
    bool myBooleanVariable = true;
    
    // By default, number values are set to 0, strings are empty, and booleans are set to false
    // You can assign values to variables when you declare them like I did above.
    // Variable names can be anything you want, but they must not have spaces in them
    bool thisIsAReallyGoodNameForAVariable = true;
    
    // Variables can also be references to game objects, unity components, or other scripts
    // These are called reference variables or Objects. By default, they are empty or "null"
    // You would declare them like this:
    private GameObject myGameObject;
    private ExampleScript myExampleScript;
    
    // Start runs once when the game starts
    // Let's assign values to the variables and print them to the console
    void Start()
    {
        // Assign a value to the integer variable
        myIntVariable = 10;
        
        // Assign a value to the float variable
        myFloatVariable = 10.5f;
        
        // Assign a value to the string variable
        myStringVariable = "Hello World!";
        
        // Assign a value to the boolean variable
        myBooleanVariable = false;
        thisIsAReallyGoodNameForAVariable = false;
        
        // Print the values of the variables to the console
        Debug.Log("myIntVariable: " + myIntVariable);
        Debug.Log("myFloatVariable: " + myFloatVariable);
        Debug.Log("myStringVariable: " + myStringVariable);
        Debug.Log("myBooleanVariable: " + myBooleanVariable);
        
        // Assign a value to the GameObject variable
        myGameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        // Once you assign a value to a GameObject variable, you can access its components
        // For example, you can access the transform component and set the position like this:
        myGameObject.transform.position = new Vector3(0, 1, 0);
    }
}

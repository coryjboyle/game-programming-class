// This is a comment. Any line that starts with // is ignored by the code compiler.
// Comments are a really handy way to communicate what your code does!

// This file is called a script and is written in a programming language called C# (pronounced C Sharp)
// In C#, every line of code ends with a semicolon ;
// Blocks of code are surrounded by curly braces { }

// If you forget a semicolon on a line or an opening or closing brace, the compiler will show an error!

// Let's break down what is happening in this script :)

// These "using" lines are telling the compiler to import certain code libraries.
// Without this, the script will have no idea what Unity can do!
using UnityEngine;


//========== The Class ===========
// C# uses an object called a class to collect all the code in one group.
// Think of a class as a container for organizing code into groups

// The public keyword lets other scripts and gameobjects access the code in this class
// The opposite of public is private. Mark variables as private if you don't want other scripts messing with them.

// The name of a class can be anything you want as long as the file name matches
// MonoBehaviour is a special Unity thing that lets this script be attached to game objects.
public class ExampleScript : MonoBehaviour
{
    // All game engines have 2 main events: Start and Update
    // Start runs one time when the game first begins and is where we setup our game's initial values
    
    // Update runs every single frame (usually around 120 times per second) and is where we handle 
    // interaction login. In some games like Minecraft, this is called Tick
    
    // In this script, let's make a cube and have it spin around because why not!
    // First let's setup an empty reference (variable) for our cube that we'll assign in Start.
    private GameObject cubeReference;
    
    // Start runs one time at the very beginning of the game.
    private void Start()
    {
        // This will print a fun message into the console window in Unity :)
        // ("Hello World" is a classic programming test phrase)
        Debug.Log("Hello World!");
        
        // Now let's fill our cubeReference with an actual cube object we'll make.
        // I googled "unity cube" and found this api example of how to make one with code:
        // https://docs.unity3d.com/ScriptReference/PrimitiveType.Cube.html
        
        cubeReference = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // The Update event runs every single frame.
    // Let's apply a tiny bit of rotation to our cube every frame to make it look like it's spinning!
    private void Update()
    {
        // Every GameObject has a "transform" component that contains position, rotation, and scale information.
        // Transform also has some code built into it to handle common movements like Rotate().
        // This type of code that is built into a class is called a Method.
        cubeReference.transform.Rotate(0.1f, 1f,0 );
        
        // Unity and other 3D programs use a coordinate system represented by X, Y, and Z
        // to describe position in 3D space.
        // Rotate needs 3 numbers separated by commas that say how we are adjusting the rotation angle
        // on each coordinate of the game object.
        // Play with each of the 3 numbers and see how it effects the spin!
    }
    
    // We did! We reached the end of our script!
    // To see this script without the comments taking up all the space,
    // open the script called ExampleScriptNoComments
    
    // If you have any auestions, ask in the discord and I'll try to answer when I can :)
    // -Cory
}


using UnityEngine;

/// <summary>
/// Gets the main camera in the scene and assigns it to the Canvas 
/// </summary>
[ExecuteInEditMode]
public class GetCanvasMainCamera : MonoBehaviour
{
    private void OnEnable()
    {
        // Get the main camera in the scene
        Camera mainCamera = Camera.main;

        // Get the Canvas component attached to this GameObject
        Canvas canvas = GetComponent<Canvas>();

        // Assign the main camera to the Canvas
        canvas.worldCamera = mainCamera;
    }
}

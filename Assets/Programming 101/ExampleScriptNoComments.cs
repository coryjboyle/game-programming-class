using UnityEngine;

public class ExampleScriptNoComments : MonoBehaviour
{
    private GameObject cubeReference;

    private void Start()
    {
        Debug.Log("Hello World!");
        cubeReference = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    private void Update()
    {
        cubeReference.transform.Rotate(0.1f, 1f, 0);
    }
}

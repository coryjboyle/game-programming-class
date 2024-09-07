using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinWaveMovement : MonoBehaviour
{
    [Range(0f, 5f)]
    public float amplitude = 3f;
    public float xSpeed = 2.5f;
    public float ySpeed = 1.5f;
    public float zSpeed = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(
            Mathf.Sin(Time.time * xSpeed) * amplitude,
            Mathf.Sin(Time.time * ySpeed) * amplitude,
            Mathf.Cos(Time.time * zSpeed) * amplitude
        );

    }
}

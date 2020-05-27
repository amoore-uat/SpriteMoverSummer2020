using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The SpriteMovement class moves the gameobject.
/// </summary>
public class SpriteMovement : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Move the gameobject up moveSpeed units per second
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        
    }
}

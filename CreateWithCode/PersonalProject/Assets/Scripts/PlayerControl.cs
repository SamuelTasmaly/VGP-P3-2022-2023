using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float speed = 10.0f;
    private float turnSpeed = 60.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the player forward based on vertical input
        transform.Translate(Vector3.forward*Time.deltaTime*speed* forwardInput);
        // Rotate the player based on vertical input
        transform.Rotate(Vector3.up, turnSpeed *horizontalInput*Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 20.0f;
        if (Input.GetKeyUp(KeyCode.LeftShift))
            speed = 10.0f;
    }
}

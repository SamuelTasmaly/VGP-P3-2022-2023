using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 45f;
    public float verticalInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical and horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward*Time.deltaTime*speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, rotationSpeed*verticalInput*Time.deltaTime);
        // tilt left/right based on arrow keys
        transform.Rotate(Vector3.up, rotationSpeed *horizontalInput*Time.deltaTime);
    }
}

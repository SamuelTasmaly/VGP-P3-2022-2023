using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20f;
    public float rotationSpeed = 45f;
    public float verticalInput;
    public float horizontalInput;
 //   public float flying = 1;

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
            // Roll the plane based on A D input
            if (Input.GetKey("z"))
            {transform.Rotate (new Vector3 (0, 0, 20) * Time.deltaTime*5);}
            if (Input.GetKey("x"))
            {transform.Rotate (new Vector3 (0,0,-20)* Time.deltaTime*5);}
        
        if (Input.GetKey("l"))
            {speed = 1;}

    }
}

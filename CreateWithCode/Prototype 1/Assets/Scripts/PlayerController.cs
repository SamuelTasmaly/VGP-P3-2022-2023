using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables 
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        // Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward*Time.deltaTime*speed* forwardInput);
        // Rotate the car based on vertical input
        transform.Rotate(Vector3.up, turnSpeed *horizontalInput*Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space)){
            //Launch projectile from player
            Instantiate(Prop_Cone_01, transform.position, Prop_Cone_01.transform.rotation);}
    }
}

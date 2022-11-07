using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if GetKey("w")
        {
            transform.Transform(Vector3.forward*Time.deltaTime*speed);
        }
    }
}

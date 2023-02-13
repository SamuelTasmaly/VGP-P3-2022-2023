using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerFloat : MonoBehaviour
{
    private float Rotatespeed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
      transform.Translate(Vector3.forward*Time.deltaTime*3);
      transform.Translate(Vector3.forward*Time.deltaTime*0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (20, 0, 0) * Time.deltaTime*Rotatespeed);

    }





}

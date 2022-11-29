using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 14;
    public bool LogsOnGround = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision){
            LogsOnGround = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(LogsOnGround){
        transform.Translate(Vector3.left * Time.deltaTime * speed);}
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public GameObject projectilePrefab;
    public ParticleSystem explosionParticle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*horizontalInput* Time.deltaTime*speed);

        //keep player inbounds
        if(transform.position.x < -14){
            transform.position = new Vector3(-14, transform.position.y, transform.position.z);
        }
        if(transform.position.x > 14){
            transform.position = new Vector3(14, transform.position.y, transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            //Launch projectile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}

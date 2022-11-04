using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private const float spawnInterval = 1.0f;
    private float timeDelay =0;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        timeDelay += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(timeDelay > spawnInterval){
                timeDelay = 0;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            }
            
        }
    }
}

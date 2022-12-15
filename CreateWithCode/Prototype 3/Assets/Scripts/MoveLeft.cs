using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 14.0f;
    private float leftBound = -15;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
      playerControllerScript =
      GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript.gameOver == false){
          transform.Translate(Vector3.left * Time.deltaTime * speed);
          if (Input.GetKeyDown(KeyCode.LeftShift)){
            speed = 20.0f;
          }
          else if (Input.GetKeyUp(KeyCode.LeftShift)){
            speed = 14;
          }
        }
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle")){
          Destroy(gameObject);
        if (Input.GetKeyDown(KeyCode.LeftShift)){
          speed = 20.0f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift)){
          speed = 14;
        }

        }
    }
}

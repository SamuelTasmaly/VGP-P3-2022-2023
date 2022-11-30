using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveLeft : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
      playerControllerScript =
      GameObject.Find("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (playerControllerScript.gameOver == false){
          transform.Translate(Vector3.left * Time.deltaTime * speed);}
    }
}

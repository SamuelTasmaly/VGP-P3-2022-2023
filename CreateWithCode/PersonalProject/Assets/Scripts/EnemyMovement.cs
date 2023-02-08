using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
  public GameObject player;
  public Transform playerTransform;
  //private Vector3 playerpos;
  public float speed = 30.0f;
  private PlayerControl playerControllerScript;
  private Rigidbody objectRb;
  private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
    //  playerpos = Player.GetComponent();
    //  Vector3 bar = playerpos.position;
    //playerControllerScript =
    playerRb = GameObject.Find("Player").GetComponent<Rigidbody>();
    objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      objectRb.AddForce(Vector3.forward * speed);


    //  transform.position = player.transform.position - Vector3.forward * -10f;
      //transform.Translate(playerpos*Time.deltaTime*speed);

    }
}

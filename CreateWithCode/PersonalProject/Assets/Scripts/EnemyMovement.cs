using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
  public GameObject player;
  public Transform playerTransform;
  //private Vector3 playerpos;
  public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
    //  playerpos = Player.GetComponent();
    //  Vector3 bar = playerpos.position;

    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate = player.transform.position - Vector3.forward * 10f;
      //transform.Translate(playerpos*Time.deltaTime*speed);

    }
}

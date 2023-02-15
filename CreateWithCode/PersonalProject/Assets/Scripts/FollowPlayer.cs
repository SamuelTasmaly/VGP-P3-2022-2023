using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public string Player = "Player";
    public Transform player;
    private float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindWithTag(Player).transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (player != null)
        {


        transform.LookAt(player);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
      }
    }
}

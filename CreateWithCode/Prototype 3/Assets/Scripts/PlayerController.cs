using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public bool isOnGround = true;
    public bool gameOver = false;
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver){
            playerRb.AddForce(Vector3.up * 50, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
          }
    }
    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Ground"))
        {
          isOnGround = true;
        } else if (collision.gameObject.CompareTag("Obstacle")){
          gameOver = true;
          Debug.Log("Game Over!");
          playerAnim.SetBool("Death_b", true);
          playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}

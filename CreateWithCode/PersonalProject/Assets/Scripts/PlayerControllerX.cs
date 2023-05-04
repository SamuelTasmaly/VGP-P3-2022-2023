using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerControllerX : MonoBehaviour
{
    private Rigidbody playerRb;
    public float speed = 5000;
    public GameObject focalPoint;
    public float score = 0;
    public float health = 20;
    public TextMeshProUGUI healthText;
    public GameObject gameOverText;
    public GameObject wall;
    public GameObject hurtPanel;
    public bool hasPowerup;
  //  public GameObject powerupIndicator;
    public int powerUpDuration = 5;


  //  private float normalStrength = 10; // how hard to hit enemy without powerup
  //  private float powerupStrength = 25; // how hard to hit enemy with powerup

    void Start()
    {
        Debug.Log("Health: 20");
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    void Update()
    {
        // Add force to player in direction of the focal point (and camera)
        float verticalInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * verticalInput * speed * Time.deltaTime);

        // Set powerup indicator position to beneath player
      //  powerupIndicator.transform.position = transform.position + new Vector3(0, -0.6f, 0);

    }

    // If Player collides with powerup, activate powerup
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
            hasPowerup = true;
            health++;
            Debug.Log("Health: " + health);
            healthText.text = "Health: " + health;
    //        powerupIndicator.SetActive(true);
        }

    }

    // Coroutine to count down powerup duration
    IEnumerator PowerupCooldown()
    {
        yield return new WaitForSeconds(powerUpDuration);
        hasPowerup = false;
    //    powerupIndicator.SetActive(false);
    }

    // If Player collides with enemy

    IEnumerator PowerupCountdownRoutine()
    {

      yield return new WaitForSeconds(1);
      hurtPanel.SetActive(false);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            hurtPanel.SetActive(true);
          //  PowerupCountdownRoutine

            health--;
            Debug.Log("Health: " + health);
            healthText.text = "Health: " + health;
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = other.gameObject.transform.position - transform.position;
            if (health <= 0)
            {
              Destroy(gameObject);
              gameOverText.SetActive(true);
            }
            hurtPanel.SetActive(false);

        }
        if (other.gameObject.CompareTag("Button"))
        {
          wall.SetActive(true);
        }

      }

  //          if (hasPowerup) // if have powerup hit enemy with powerup force
  //          {
  //              enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
  //          }
  //          else // if no powerup, hit enemy with normal strength
  //          {
  //              enemyRigidbody.AddForce(awayFromPlayer * normalStrength, ForceMode.Impulse);
  //          }
  //          if (other.gameObject.CompareTag("Powerup"))
  //          {
  //                Destroy(other.gameObject);
  //                hasPowerup = true;
              //    powerupIndicator.SetActive(true);
  //                StartCoroutine(PowerupCooldown());
  //          }






}

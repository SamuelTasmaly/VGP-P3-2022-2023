using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    private int score;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public List<GameObject> targets;
    private float spawnRate = 1.0f;
    public bool isGameActive;
    public Button restartButton;
    public GameObject titleScreen;
    public int lives;
    public GameObject pauseScreen;
    private bool paused;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void StartGame(int difficulty)
    {
      UpdateLives(3);
      spawnRate /= difficulty;
      isGameActive = true;
      score = 0;
      StartCoroutine(SpawnTarget());
      UpdateScore(0);
      titleScreen.gameObject.SetActive(false);
    }
    public void GameOver()
    {
      gameOverText.gameObject.SetActive(true);
      restartButton.gameObject.SetActive(true);
      isGameActive = false;
    }


    public void RestartGame()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    IEnumerator SpawnTarget()
    {
      while (isGameActive)
      {
        yield return new WaitForSeconds(spawnRate);
        int index = Random.Range(0, targets.Count);
        Instantiate(targets[index]);
      }
    }
    public void UpdateScore(int scoreToAdd)
    {
      score += scoreToAdd;
      scoreText.text = "Score: " + score;
    }
    public void UpdateLives(int livesToChange)
    {
      lives += livesToChange;
      livesText.text = "Lives: " + lives;
      if (lives <= 0)
      {
        GameOver();
      }
    }

    void ChangePaused()
    {
      if (!paused)
      {
        paused = true;
        pauseScreen.SetActive(true);
        Time.timeScale = 0;

      }
      else
      {
        paused = false;
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
      }
    }


    // Update is called once per frame
    void Update()
    {
      
      if (Input.GetKeyDown(KeyCode.P))
      {
        ChangePaused();
      }
    }
}

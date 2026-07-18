using TMPro;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scores : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI gameOverText;
    public GameObject restartButton;

    void Start()
    {
        livesText.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString();
        Debug.Log("Score is now: " + score);
    }

    public void LoseLife()
    {
        lives--;
        livesText.text = lives.ToString();

        if(lives <= 0)
        {
            gameOverText.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    public float score = 0;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverText;
    public GameObject restartButton;
    public bool isGameOver = false;

    void Start()
    {
        
    }


    void Update()
    {
        if (!isGameOver)
        {
            score++;
            scoreText.text = score.ToString();
        }

    }

    public void GameOver()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

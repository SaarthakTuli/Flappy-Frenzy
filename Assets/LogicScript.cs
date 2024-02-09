using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text highScoreText;

    public GameObject gameOverScreen;

    [ContextMenu("+ Score")]
    public void addScore(int scoreToAdd) {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        int highscore = PlayerPrefs.GetInt("highscore");

        if (highscore > playerScore) {
            highScoreText.text = "Highscore is: " + highscore;
        } else {
            highScoreText.text = "New Highscore is: " + playerScore;
             PlayerPrefs.SetInt("highscore", playerScore);
        }
        
        gameOverScreen.SetActive(true);
    }
}

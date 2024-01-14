using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicManager : MonoBehaviour
{
    public Text scoreText;
    public int playerScore;
    public GameObject gameOverScreen;
    public AudioClip pointEarned;
    [ContextMenu("Increase the score")] // attribute to run the function in unity itself
    public void addScore()
    {
        Debug.Log("inside addScore()");
        AudioSource.PlayClipAtPoint(pointEarned, transform.position);
        playerScore += 1;
        scoreText.text=playerScore.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

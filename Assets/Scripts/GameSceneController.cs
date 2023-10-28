using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSceneController : MonoBehaviour
{
    public static double CurrentScore = 0f;
    public float gameTime = 30f;

    [Header("Camera")]
    public float cameraMoveSpeed = 3f;
    public Camera mainCamera;

    [Header("UI")]
    public Text scoreText;
    public Text timeText;
    public Text endedGameText;

    void Update()
    {
        UpdateScore();

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnTakeChest()
    {
        CurrentScore += 100;
        endedGameText.text = "You receive: " + 100 + " points";
    }

    private void UpdateScore()
    {
        scoreText.text = "You score: " + CurrentScore.ToString();
    }
}

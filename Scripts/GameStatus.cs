﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    //config parameters
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 83;
    [SerializeField] TextMeshProUGUI scoreText;


    //State variables
    [SerializeField] int currentScore = 0;

    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            Destroy(gameObject);
        }

        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


    void Start()
    {
        //Makes the variable currrentScore to string
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }
}

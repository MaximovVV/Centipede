using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //Manage and display player scores
    public Text textCurrentScore, textHighScore;
    static int CurrentScore, HighScore;

    private void Start()
    {
        HighScore = PlayerPrefs.GetInt("HighScore"); //Load value of High Score from Prefs 
        textHighScore.text = HighScore.ToString();
    }

    private void GetScore()
    {
        CurrentScore = PlayerPrefs.GetInt("CurrentScore"); //Load value of Last Score from Prefs (For the Menu of death) 
    }
    public static void RefreshScore()
    {
        CurrentScore = 0;
    }
    private void Update()
    {
        textCurrentScore.text = CurrentScore.ToString();
    }

    public static void AddScore(int addCount)
    {
        CurrentScore += addCount;
    }



    public static void SetHighScore()
    {
        PlayerPrefs.SetInt("CurrentScore", CurrentScore);
        if (HighScore < CurrentScore)
        {
            HighScore = CurrentScore;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }
    }
}

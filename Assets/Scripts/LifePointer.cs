using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LifePointer : MonoBehaviour { //Class for player life cycle management

    public Text textMessage, textLife;  
    static int LifePoint = 10;

	void Start () {
    }
 
    public static void SubLifePoint()
    {
        LifePoint -= 1;
    }

    public static void addLifePoint(int count)
    {
        LifePoint = count;
    }

    public static void EndGame()
    {
        Score.SetHighScore();
    }

    // Update is called once per frame
    void Update () {
		if(LifePoint <= 0)
        {
            EndGame();
            SceneManager.LoadScene("EndGame");
        }

        textLife.text = LifePoint.ToString();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour //class to control the buttons of all menus
{ 

    public void ButtonPlayPressed()
    {

        LifePointer.addLifePoint(5);    //Updating life
        Score.RefreshScore();           //and scores
        SceneManager.LoadScene("1");
    }

    public void ButtonMenuPressed()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ButtonExitPressed()
    {
        Application.Quit();
    }
}

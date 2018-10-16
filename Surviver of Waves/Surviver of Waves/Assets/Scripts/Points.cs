using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{


    public Text pointsDisplay;
    public int points = 0;
    private int highScoreOld;
    public Text highScore;


    private void Start()
    {
       
        highScoreOld = PlayerPrefs.GetInt("HighScore");
        highScore.text = "" + highScoreOld;

    }




    private void Update()
    {
        pointsDisplay.text = "Points:" + points;


        if (points > highScoreOld)
        {
            PlayerPrefs.SetInt("HighScore", +points);
            highScore.text = points.ToString();
        }

    }



    public void Reset()
    {
        points = 0;
        PlayerPrefs.SetInt("HighScore", 0);
        highScore.text = points.ToString();
    }

}
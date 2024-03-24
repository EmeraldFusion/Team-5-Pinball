using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public int bumperPoints;
    public Text highScore;
    
    // Start is called before the first frame update
    void Start()
    {
        bumperPoints = 0;
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        
    }

    public void addToScore()
    {
        bumperPoints += 50;
        Debug.Log("Hello");
    }

    public void HighScore()
    {
        score.text = bumperPoints.ToString();

        if (bumperPoints > PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", bumperPoints);
            highScore.text = bumperPoints.ToString();
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highScore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }
}

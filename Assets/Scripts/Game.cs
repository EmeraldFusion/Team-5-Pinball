using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    [HideInInspector] public Controls input;

    public static Game Instance { get; private set; }

    public int curScore { get; private set; }
    public int highScore { get; private set; }



    void Awake()
    {
        input = new Controls();
        input.Enable();
        Instance = this;
    }

    private void OnDisable()
    {
        //While game is off save the score for future uses
        PlayerPrefs.SetInt(Consts.PlayerPrefs.HIGHSCORE, highScore);
    }
   
    
    public void AddScore(int amount)
    {
        curScore += amount;

        if (curScore > highScore)
        {
            highScore = curScore;
        }
    }

}
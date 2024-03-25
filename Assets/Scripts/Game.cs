using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    [HideInInspector] public Controls input;
    public Flipper PaddleR;
    public Flipper PaddleL;
    public Flipper HitR;
    public Flipper HitL;
    public Ball ball;
    public Text changingText;

    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        
        if (input.Default.FlipR.WasPressedThisFrame())
        {
            PaddleR.Flip();
        }
        else if (input.Default.FlipL.WasPressedThisFrame())
        {
            PaddleL.Flip();
        }
        else if (input.Default.ExtraR.WasPressedThisFrame())
        {
            HitR.Flip();
        }
        else if (input.Default.ExtraL.WasPressedThisFrame())
        {
            HitL.Flip();
        }
        else if (input.Default.Restart.WasPressedThisFrame())
        {
            ball.SpawnBall();
        }
    }
}
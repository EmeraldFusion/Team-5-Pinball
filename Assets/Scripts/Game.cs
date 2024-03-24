using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [HideInInspector] public Controls input;
    public Flipper PaddleR;
    public Flipper PaddleL;
    public Flipper HitR;
    public Flipper HitL;
    public Ball ball;
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

    private void Start()
    {
        //Gets high score when the game starts
        highScore = PlayerPrefs.GetInt(Consts.PlayerPrefs.HIGHSCORE, 0);
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
            Debug.Log(curScore);
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
        else if (Input.GetKey(KeyCode.Escape))
        {
            ball.RestartGame();
        }
    }
}
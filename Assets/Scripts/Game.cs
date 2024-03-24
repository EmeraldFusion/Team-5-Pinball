using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // set in inspector
    public Flipper PaddleR;
    public Flipper PaddleL;
    public Ball ball;

    // other fields
    [HideInInspector] public Controls input;

    public static Game Instance { get; private set; }

    // scores
    public int CurScore { get; private set; }
    public int HighScore { get; private set; }

    // Life Cycle methods
    void Awake()
    {
        input = new Controls();
        input.Enable();
        Instance = this;
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
        else if (input.Default.LaunchB.WasPressedThisFrame())
        {
<<<<<<< Updated upstream
            ball.Launch();
=======
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

    // adds score and sets high score
    public void AddScore(int amount)
    {
        CurScore += amount;
        if (CurScore > HighScore)
        {
            HighScore = CurScore;
>>>>>>> Stashed changes
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore , _enemyScore;
    public Ball ball;
    public Paddle_Controller playerPaddle, enemyPaddle;
    public Text playerScoreText, enemyScoreText;
    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void EnemyScores()
    {
        _enemyScore++;
        this.enemyScoreText.text = _enemyScore.ToString();
        ResetRound();
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.enemyPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartForce();
    }

}


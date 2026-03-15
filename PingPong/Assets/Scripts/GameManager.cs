using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public BallMovement ball;
    public GameObject Losing;
    public GameObject Winning;
    public Text playerPointsText;
    public Text computerPointsText;

    private int _playerScore;
    private int _computerScore;
    private int WinningScore = 10;


    public void PlayerScores()
    {
        _playerScore++;
       this.playerPointsText.text = _playerScore.ToString();

        this.ball.ResetBall();

        if(_playerScore >= WinningScore)
        {
            Winner();
        }
    }

    public void ComputerScores() 
    {
        _computerScore++;
        this.computerPointsText.text = _computerScore.ToString();


        this.ball.ResetBall();

        if (_computerScore >= WinningScore)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        Losing.SetActive(true);
    }


    public void Winner()
    {
        Winning.SetActive(true);
    }
}

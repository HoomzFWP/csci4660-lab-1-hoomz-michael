using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1padle;
    public GameObject player1goal;

    [Header("Player 2")]
    public GameObject player2padle;
    public GameObject player2goal;

    [Header("Score UI")]
    public GameObject player1text;
    public GameObject player2text;

    private int player1score;
    private int player2score;

    public void Player1Scored() 
    {
        player1score++;
        player1text.GetComponent<TextMeshProUGUI>().text = player1score.ToString();
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2score++;
        player2text.GetComponent<TextMeshProUGUI>().text = player2score.ToString();
        ResetPosition();
    }

    private void ResetPosition()
    {
        ball.GetComponent<ball>().Reset();
        player1padle.GetComponent<paddle>().Reset();
        player2padle.GetComponent<paddle>().Reset();
    }
}

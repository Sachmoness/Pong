using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    int player1Score = 0;
    int player2Score = 0;

    public GameObject player1;
    public GameObject player2;
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
         print("Player 1: " + player1Score + " ,Player 2: " + player2Score);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void P1Scores(){
        player1Score++;
        Reset();
    }

    public void P2Scores(){
        player2Score++;
        Reset();
    }

    void Reset(){
        Ball.GetComponent<Ball>().resetBallPos();
        player1.GetComponent<P1Movement>().resetPos();
        player2.GetComponent<P2Movement>().resetPos();
        print("Player 1: " + player1Score + " ,Player 2: " + player2Score);
    }
}

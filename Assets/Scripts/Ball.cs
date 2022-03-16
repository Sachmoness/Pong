using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _ballBody;

    private float _ballSpeed = 3f;
    Vector2 direc;

    public GameObject GameManager;
    private Manager _managerScript;
    // Start is called before the first frame update
    void Start()
    {
        _ballBody = GetComponent<Rigidbody2D>();
        _managerScript = GameManager.GetComponent<Manager>();

        CreateRandomNums();
        BallStart();
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void BallStart(){
        _ballBody.AddForce(direc * _ballSpeed, ForceMode2D.Impulse);
    }

    void CreateRandomNums(){
        int x = Random.Range(-4,-4);
        int y = Random.Range(-4,-4);

        direc = new Vector2(x,y);
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Right"){
            _managerScript.P1Scores();
        }
        else if(collisionInfo.gameObject.tag == "Left"){
            _managerScript.P2Scores();
        }
    }
    
    public void resetBallPos(){
        _ballBody.position = Vector2.zero;
        _ballBody.velocity = Vector2.zero;

        CreateRandomNums();
        BallStart();
    }
}

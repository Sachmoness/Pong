using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Movement : MonoBehaviour
{

    private Rigidbody2D _playerBody;

    private float _movementSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        _playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        UserInput();
    }

    void UserInput(){
        if(Input.GetKey(KeyCode.W)){
            _playerBody.MovePosition(transform.position + Vector3.up * Time.fixedDeltaTime * _movementSpeed);
        }

        else if(Input.GetKey(KeyCode.S)){
            _playerBody.MovePosition(transform.position + Vector3.down * Time.fixedDeltaTime * _movementSpeed);
        }
    }

    public void resetPos(){
        transform.position = new Vector3 (-14f,0f, 0f);
    }
}

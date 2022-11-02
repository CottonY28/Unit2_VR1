using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class PlayerMovement : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    float xMovement;
    float yMovement;
    public int xSpeed = 4;
    public int ySpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        Debug.Log(xMove);
        Debug.Log(player);
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal")*xSpeed;
        yMovement = Input.GetAxis("Vertical")*ySpeed;
        xMove = new Vector2(xMovement, yMovement);
        player.Translate(xMove*Time.deltaTime);
    }
}
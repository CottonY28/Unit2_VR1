using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector2 move;
    Transform player;
    float xMovement;
    float yMovement;
    public int xSpeed = 4;
    public int ySpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        Debug.Log(move);
        Debug.Log(player);
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal") * xSpeed;
        yMovement = Input.GetAxis("Vertical") * ySpeed;
        move = new Vector2(xMovement, yMovement);
        player.Translate(move * Time.deltaTime);
        if (Input.GetAxis("Horizontal") > 0)
        {
            player.localScale = new Vector3(4, 4, 1);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            player.localScale = new Vector3(-4, 4, 1);
        }
    }
}

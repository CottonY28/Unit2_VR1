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
        Vector2 flip = new Vector2(-1.1f, 1.1f);
        transform.localScale *= flip;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    Vector2 move;
    Transform enemy;
    float xMovement;
    float yMovement;
    public int xSpeed = 4;
    public int ySpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        enemy = gameObject.transform;
        xMovement = 0.0f;
        yMovement = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(xMovement, yMovement);
        enemy.Translate(move * Time.deltaTime);
    }
}

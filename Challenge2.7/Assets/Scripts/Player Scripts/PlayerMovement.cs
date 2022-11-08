using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 move;

    Transform player;

    float xMovement;
    public int xSpeed = 4;

    public Animator animator;

    Rigidbody2D m_Rigidbody;
    public float m_Thrust = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxis("Horizontal") * xSpeed;

        animator.SetFloat("Speed", Mathf.Abs(xMovement));

        move = new Vector2(xMovement, 0.0f);

        player.Translate(move * Time.deltaTime);

        if (Input.GetAxis("Horizontal") > 0)
        {
            player.localScale = new Vector3(6, 6, 1);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            player.localScale = new Vector3(-6, 6, 1);
        }

        if (Input.GetButton("Jump"))
        {
            m_Rigidbody.AddForce(transform.up * m_Thrust);
            animator.SetBool("Jumping", true);
        } 
        else
        {
            animator.SetBool("Jumping", false);
        }
    }
}

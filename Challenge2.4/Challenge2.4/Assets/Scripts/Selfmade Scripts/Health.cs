using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    Rigidbody2D player = null;
    int beginningHealth = 3;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Your total amount of hp will start at " + beginningHealth);
        testing();
    }

    // Update is called once per frame
    void Update()
    {
        //playerStatus();
        //beginningHealth -= 1;
    }

    void playerStatus()
    {
        if (player == null)
        {
            Debug.Log("The current status of the player character is null");
        }
        if (beginningHealth == 3)
        {
            Debug.Log("Player is at max health");
        }
        else if (beginningHealth == 2)
        {
            Debug.Log("Player has been hurt");
        }
        else if (beginningHealth == 1)
        {
            Debug.Log("Player is baddly hurt");
        }
        else
        {
            Debug.Log("Player is dead");
        }
    }

    void testing()
    {
        for(var i = 0; i <= 10; i++)
        {
            Debug.Log("Kill me please");
        }
    }
}
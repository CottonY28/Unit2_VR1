using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath : MonoBehaviour
{
    int num1 = 314159265;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        product();
        Debug.Log(num1);
    }

    void product()
    {
        num1 = num1 * 2;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public bool player1;
    //bool ai;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (player1 == true)
        {
            if (Input.GetKey(KeyCode.W))
                transform.Translate(0, 0.02f, 0);
            if (Input.GetKey(KeyCode.S))
                transform.Translate(0, -0.02f, 0);
            if (Input.GetKey(KeyCode.A))
                transform.Translate(-0.02f, 0, 0);
            if (Input.GetKey(KeyCode.D))
                transform.Translate(0.02f, 0, 0);
        }
        /*
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
                transform.Translate(0, 0.02f, 0);
            if (Input.GetKey(KeyCode.DownArrow))
                transform.Translate(0, -0.02f, 0);
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Translate(-0.02f, 0, 0);
            if (Input.GetKey(KeyCode.RightArrow))
                transform.Translate(0.02f, 0, 0);
        }
        */
       
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int score=0;
    public Text Score;
    Collider2D PuckCol;
    void Start()
    {
        Score.text = ("Score: 0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "puck")
        {
            PuckCol = collision;
            // collision.transform.position=new Vector3(0, 0, 0);
            Invoke("Wait", 0.5f);
                

        }
    }
    void Wait()
    {
        score++;
        Score.text = ("Score: " + score);
        PuckCol.transform.position = new Vector3(0, 0, 0);
        PuckCol.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }
}

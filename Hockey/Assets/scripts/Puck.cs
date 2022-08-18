using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    Rigidbody2D rb;
    PhotonView pv;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pv = GetComponent<PhotonView>();
    }

    [PunRPC]
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("Shooting");
            pv.RequestOwnership();
            rb.AddForce(Vector2.left * 8);

        }
       // if (Input.GetMouseButtonDown(1))
         //   rb.AddForce(Vector2.right * 8);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }
}

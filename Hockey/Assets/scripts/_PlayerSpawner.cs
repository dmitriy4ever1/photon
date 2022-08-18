using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _PlayerSpawner : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    
    private void Start()
    {
        int num = PhotonNetwork.CurrentRoom.Players.Count;
        if (num == 1)
        {
            PhotonNetwork.Instantiate(player1.name, new Vector2(7f, 0f), Quaternion.identity);
        }
        // rhino is next, after bear is in
        if (num == 2)
        {
            // first player (bear) is already in, we're now adding Rhino
            PhotonNetwork.Instantiate(player2.name, new Vector2(-7f, 0f), Quaternion.identity);
        }
    }


}

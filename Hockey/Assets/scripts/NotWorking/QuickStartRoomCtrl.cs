using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickStartRoomCtrl : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private int MultiplayerSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public override void OnEnable()
    {
        PhotonNetwork.AddCallbackTarget(this);
    }
    public override void OnDisable()
    {
        PhotonNetwork.RemoveCallbackTarget(this);
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room");
        StartGame();
    }

    private void StartGame()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            Debug.Log("Starting Game");

            PhotonNetwork.LoadLevel(MultiplayerSceneIndex);
        }
    }
}

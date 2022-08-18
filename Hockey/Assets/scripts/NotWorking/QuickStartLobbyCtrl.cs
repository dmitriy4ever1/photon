using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickStartLobbyCtrl : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private GameObject QuickStartButton;

    [SerializeField]
    private GameObject QuickCancelButton;

    [SerializeField]
    private int RoomSize;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.AutomaticallySyncScene=true;
        QuickStartButton.SetActive(true);
        
    }
    public void QuickStart()
    {
        QuickStartButton.SetActive(false);
        QuickCancelButton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();
        Debug.Log("Quick Start");
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to join a room.");
        CreateRoom();
    }
    // Update is called once per frame
    void CreateRoom()
    {
        Debug.Log("Creating Room.");
        int RandomRoomNum = Random.Range(0, 1000);
        RoomOptions RoomOpts = new RoomOptions() { IsVisible = true, IsOpen = true, MaxPlayers = (byte)RoomSize };
        PhotonNetwork.CreateRoom("Room" + RandomRoomNum, RoomOpts);
        Debug.Log(RandomRoomNum);
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to create a room... trying again");
        CreateRoom();
    }
    public void QuickCancel()
    {
        QuickCancelButton.SetActive(false);
        QuickStartButton.SetActive(true);
        PhotonNetwork.LeaveRoom();
    }
}

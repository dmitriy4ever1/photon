using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _CreateRoom : MonoBehaviourPunCallbacks
{

    public InputField createInput;
    public InputField joinInput;
    public Text loadingTxt;
    void Start()
    {
        loadingTxt.text = "Loading...";
        PhotonNetwork.ConnectUsingSettings();
    }
    
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        print("room is " + PhotonNetwork.CurrentRoom);

        loadingTxt.text = "";
    }


    public void JoinOrCreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.IsVisible = false;
        PhotonNetwork.JoinOrCreateRoom(createInput.text, roomOptions, null);
    }
   
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("IceHockey");
    }

}

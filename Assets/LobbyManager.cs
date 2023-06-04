using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using TMPro;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public TMP_InputField crText;
    public TMP_InputField jrText;


  public override void OnJoinedRoom()
    {
        SceneManager.LoadScene(5);
    }
    
    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(crText.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(jrText.text);
    }

  
}

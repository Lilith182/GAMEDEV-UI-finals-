using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Spawner : MonoBehaviour
{
    
    public GameObject paddle;
    public static bool player1exists = false;
    void Start()
    {

        if(player1exists == false)
        {
            PhotonNetwork.Instantiate(paddle.name , new Vector3(-373, 0,0), Quaternion.identity);
        } 
        else
        {
            PhotonNetwork.Instantiate(paddle.name , new Vector3(373, 0,0), Quaternion.identity);
        }
    }


 
}


using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Photonlobby : MonoBehaviourPunCallbacks
{
    public Text estado;
    public static Photonlobby lobby;
    public GameObject recorridoButton;
    RoomInfo[] room;
    public GameObject cancelButton;

    public void Awake()
    {
        lobby=this;
    }
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    public override void OnConnected()
    {
        estado.text= "La conexion es establecida";
        Debug.Log("La conexion es establecida");
        PhotonNetwork.AutomaticallySyncScene = true;
        recorridoButton.SetActive(true);
    }
    public void OnRecorridoButtonClicked()
    {
        Debug.Log("Algo esta en el RecorridoButton");
        recorridoButton.SetActive(false);
        cancelButton.SetActive(true);
        PhotonNetwork.JoinRandomRoom();
    }
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("Fallo la union al Romm");
        CreateRoom();
    }
    void CreateRoom()
    {
        Debug.Log("Llego a Create Room");
        int randomRoomName = Random.Range(0, 10000);
        RoomOptions roomOps = new RoomOptions()
        {
            IsVisible = true,
            IsOpen = true,
            MaxPlayers = (byte)MultiplayerSettings.multiplayerSettings.maxPlayers
        };
        PhotonNetwork.CreateRoom("Room"+randomRoomName,roomOps,null);

    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Fallo la creacion del Room");
        CreateRoom();
    }
    public void onCancelButtonCliked()
    {
        Debug.Log("Llego a OnCancelCliked");
        recorridoButton.SetActive(false);
        cancelButton.SetActive(true);
        PhotonNetwork.LeaveRoom();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

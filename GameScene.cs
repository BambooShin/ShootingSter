using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class GameScene : MonoBehaviourPunCallbacks
{
    #region 変数
    //instantiateしたゲームオブジェクトを格納
    private GameObject _instantiateGameObject;
    #endregion

    #region プロパティ
    public GameObject InstantiateGameObject
    {
        get => _instantiateGameObject;
        set => _instantiateGameObject = value;
    }

    #endregion

    #region メソッド
    private void Start()
    {

        // プレイヤー自身の名前を"Player"に設定する
        PhotonNetwork.NickName = "Player";

        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions(), TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        var position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f));
        _instantiateGameObject = PhotonNetwork.Instantiate("Avatar", position, Quaternion.identity);

        /*
        // ルームを作成したプレイヤーは、現在のサーバー時刻をゲームの開始時刻に設定する
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.CurrentRoom.SetStartTime(PhotonNetwork.ServerTimestamp);
        }
        */

        // ルームが満員になったら、以降そのルームへの参加を不許可にする
        if (PhotonNetwork.CurrentRoom.PlayerCount == PhotonNetwork.CurrentRoom.MaxPlayers)
        {
            PhotonNetwork.CurrentRoom.IsOpen = false;
        }
    }
    #endregion
}


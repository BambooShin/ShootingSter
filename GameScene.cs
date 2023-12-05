using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class GameScene : MonoBehaviourPunCallbacks
{
    #region �ϐ�
    //instantiate�����Q�[���I�u�W�F�N�g���i�[
    private GameObject _instantiateGameObject;
    #endregion

    #region �v���p�e�B
    public GameObject InstantiateGameObject
    {
        get => _instantiateGameObject;
        set => _instantiateGameObject = value;
    }

    #endregion

    #region ���\�b�h
    private void Start()
    {

        // �v���C���[���g�̖��O��"Player"�ɐݒ肷��
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
        // ���[�����쐬�����v���C���[�́A���݂̃T�[�o�[�������Q�[���̊J�n�����ɐݒ肷��
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.CurrentRoom.SetStartTime(PhotonNetwork.ServerTimestamp);
        }
        */

        // ���[���������ɂȂ�����A�ȍ~���̃��[���ւ̎Q����s���ɂ���
        if (PhotonNetwork.CurrentRoom.PlayerCount == PhotonNetwork.CurrentRoom.MaxPlayers)
        {
            PhotonNetwork.CurrentRoom.IsOpen = false;
        }
    }
    #endregion
}


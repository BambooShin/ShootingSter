using Photon.Pun;
using UnityEngine;

public class PlayerController : MonoBehaviourPunCallbacks
{
    //GameScene�X�N���v�g���`
    GameScene _gameScene;
    private void Awake()
    {
        _gameScene = GetComponent<GameScene>();
    }
    // Start is called before the first frame update
    private void Start()
    {
        GameObjectStruct gameobjectstruct;
        gameobjectstruct._player = _gameScene.InstantiateGameObject;
    }

    // Update is called once per frame
    private void Update()
    {
        // ���g�����������I�u�W�F�N�g�����Ɉړ��������s��
        if (photonView.IsMine)
        {
            var input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
            transform.Translate(3f * Time.deltaTime * input.normalized);

        }
    }

    private struct GameObjectStruct
    {
        public GameObject _player;
    }
}

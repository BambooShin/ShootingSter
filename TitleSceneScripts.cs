// ---------------------------------------------------------  
// TitleSceneScripts.cs  
// タイトル画面における動作を格納
// 作成日:  20231205
// 作成者:  竹内
// ---------------------------------------------------------  
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneScripts : MonoBehaviour
{

    #region 変数  
    //GameSceneスクリプトを定義
    private GameScene _gameScene;
    #endregion

    #region プロパティ  

    #endregion

    #region メソッド  

    /// <summary>  
    /// 初期化処理  
    /// </summary>  
    private void Awake()
    {
        //定義されたGameSceneを格納
        _gameScene = GetComponent<GameScene>();
    }

    /// <summary>  
    /// 更新前処理  
    /// </summary>  
    private void Start()
    {
        //Photon内のキューを止めてゲームオブジェクトが生成されないようにする
        _gameScene.IsPhotonQueue = false;
    }

    /// <summary>  
    /// 更新処理  
    /// </summary>  
    private void Update()
    {
    }

    public void PushStartButton()
    {
        SceneManager.LoadScene("GameScene");
    }
    #endregion
}

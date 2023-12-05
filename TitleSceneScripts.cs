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

    #endregion

    #region プロパティ  

    #endregion

    #region メソッド  

    /// <summary>  
    /// 初期化処理  
    /// </summary>  
    private void Awake()
    {

    }

    /// <summary>  
    /// 更新前処理  
    /// </summary>  
    private void Start()
    {
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

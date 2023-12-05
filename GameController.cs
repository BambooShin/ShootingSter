// ---------------------------------------------------------  
// GameController.cs  
// プレイヤーの挙動や弾丸の発射に関して記述
// 作成日:  20231121
// 作成者:  竹内
// ---------------------------------------------------------  
using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    #region 変数  
    //プレイヤーオブジェクト
    [SerializeField] GameObject _player;
    //弾丸オブジェクト
    [SerializeField] GameObject[] _bullet;
    #endregion
  
    #region プロパティ  
  
    #endregion
  
    #region メソッド  
  
     /// <summary>  
     /// 初期化処理  
     /// </summary>  
     void Awake()
     {
     }
  
     /// <summary>  
     /// 更新前処理  
     /// </summary>  
     void Start ()
     {
  
     }
  
     /// <summary>  
     /// 更新処理  
     /// </summary>  
     void Update ()
     {
     }
  
    #endregion
}

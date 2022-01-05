using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2D : MonoBehaviour
{
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 15000)]
    public float jump = 300;


    private Rigidbody2D rig;

    //遊戲開始的時候會透過這個API取的遊戲元件
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    #region 方法
    //1.玩家是否有按移動案鍵 左右方向鍵 OR A,D
    //2.物件移動行為(API)
    private void Move()
    {

        float h = Input.GetAxis("Horixontal");
        print("玩家左右按鍵值" + h);
    
    }
    #endregion
}

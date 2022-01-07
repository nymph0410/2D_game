using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2D : MonoBehaviour
{
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 15000)]
    public float jump = 300;
    [Header("檢查地板尺寸與位移")]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundoffset;
    [Header("跳躍按鍵與可跳躍圖層")]
    public  KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;


    private Rigidbody2D rig;

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        Gizmos.DrawSphere(transform.position +
        transform.TransformDirection(checkGroundoffset), checkGroundRadius);
    }

    //遊戲開始的時候會透過這個API取的遊戲元件
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        Flip();
    }

    #region 方法
    //1.玩家是否有按移動案鍵 左右方向鍵 OR A,D
    //2.物件移動行為(API)
    private void Move()
    {
        //h值 指定為數入 取得倫向(水平) 水平倫代表左右鍵和A,D
        float h = Input.GetAxis("Horizontal");
        print("玩家左右按鍵值" + h);

        //鋼體元件.加速度 = v新二為向量(h值 * 移動速度,0);
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    
    }

    private void Flip() 
    {
        float h = Input.GetAxis("Horizontal");

        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }

        else if (h > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }
    #endregion
}

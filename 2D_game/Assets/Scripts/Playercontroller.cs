using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [Header("移動速度")]
    public float speed = 1;
    [Header("跳躍高度")]
    public float jump = 200f;
    [Header("Run")]
    public string parRun = "跑步開關";
    [Header("Jump")]
    public string parJump = "跳躍觸發";
    [Header("Hit")]
    public string parDead = "死亡開關";

}

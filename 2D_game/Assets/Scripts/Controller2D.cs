using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2D : MonoBehaviour
{
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 15000)]
    public float jump = 300;


    private Rigidbody2D rig;

    //�C���}�l���ɭԷ|�z�L�o��API�����C������
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    #region ��k
    //1.���a�O�_�������ʮ��� ���k��V�� OR A,D
    //2.���󲾰ʦ欰(API)
    private void Move()
    {

        float h = Input.GetAxis("Horixontal");
        print("���a���k�����" + h);
    
    }
    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller2D : MonoBehaviour
{
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 15000)]
    public float jump = 300;
    [Header("�ˬd�a�O�ؤo�P�첾")]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundoffset;
    [Header("���D����P�i���D�ϼh")]
    public  KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;


    private Rigidbody2D rig;

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        Gizmos.DrawSphere(transform.position +
        transform.TransformDirection(checkGroundoffset), checkGroundRadius);
    }

    //�C���}�l���ɭԷ|�z�L�o��API�����C������
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

    #region ��k
    //1.���a�O�_�������ʮ��� ���k��V�� OR A,D
    //2.���󲾰ʦ欰(API)
    private void Move()
    {
        //h�� ���w���ƤJ ���o�ۦV(����) �����ۥN���k��MA,D
        float h = Input.GetAxis("Horizontal");
        print("���a���k�����" + h);

        //���餸��.�[�t�� = v�s�G���V�q(h�� * ���ʳt��,0);
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

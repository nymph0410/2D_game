using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("�ˬd�l�ܰϰ�j�p�P�첾")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;
    [Header("���ʳt��"), Range(0, 10)]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    [Header("�ʵe�Ѽ�")]
    public string parameterWalk = "�}������";
    public string parameterAttack = "Ĳ�o����";
    [Header("���V�ؼЪ���")]
    public Transform target;
    [Header("�����Z��"), Range(0, 5)]
    public float attackDistance = 1.3f;
    [Header("�����N�o�ɶ�"), Range(0, 10)]
    public float attackCD = 2.8f;
    [Header("�ˬd�����ϰ�j�p�P�첾")]
    public Vector3 v3AttackSize = Vector3.one;
    public Vector3 v3AttackOffset;

    private float angle = 0;
    private Rigidbody2D rig;
    private Animator ani;
    private float timerAttack;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }


    private void OnDrawGizmos()
    {
        // ���w�ϥܪ��C��
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        // ø�s�ߤ���(���ߡA�ؤo)
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize);

        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3AttackOffset), v3AttackSize);
    }

    private void Update()
    {
        CheckTargetInArea();
    }

    private void CheckTargetInArea()
    {
        // 2D ���z.�л\����(���ߡA�ؤo�A����)
        Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize, 0, layerTarget);

        if (hit) Move();
    }

    private void Move()
    {
        #region �ϥΧP�_�� if �P�T���B��l�����
        
        if (target.position.x > transform.position.x)
        {
            
        }
        else if (target.position.x < transform.position.x)
        {
           
        }

        angle = target.position.x > transform.position.x ? 180 : 0;
        
        transform.eulerAngles = Vector3.up * angle;

        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));
        ani.SetBool(parameterWalk, true);

        
        float distance = Vector3.Distance(target.position, transform.position);
        
        #endregion

        if (distance <= attackDistance)     
        {
            rig.velocity = Vector3.zero;   
            
        }
    }

    [Header("�����O"), Range(0, 100)]
    public float attack = 35;



    
}

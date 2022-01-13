using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("�ˬd�l�ܰϰ�j�p�P�첾")]
    public Vector3 veTrackSize = Vector3.one;
    public Vector3 v3TrackOffseset;
    [Header("���ʳt��")]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;

     
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection (v3TrackOffseset), veTrackSize);
    }

    private void Update()
    {
        CheckTargetInArea();
    }
    private void CheckTargetInArea() 
    {
        Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3TrackOffseset), veTrackSize,0 , layerTarget);

        if (hit) print(hit.name);
    
    }

}

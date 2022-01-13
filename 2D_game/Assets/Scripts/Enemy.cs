using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("檢查追蹤區域大小與位移")]
    public Vector3 veTrackSize = Vector3.one;
    public Vector3 v3TrackOffseset;
    [Header("移動速度")]
    public float speed = 1.5f;
    [Header("目標圖層")]
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

using UnityEngine;
using System.Collections;

public class DiaLogueSysteam : MonoBehaviour
{
    [Header("��ܶ��j"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("�e����ܨt��")]
    public GameObject goDialogue;

    private void Start()
    {
        StartCoroutine(TypeEffect());
    }

    private IEnumerator TypeEffect() 
    {
        string test = "���o�A�A�n~";

        for (int i = 0; i < test.Length; i++)
        {
            print(test[i]);
            yield return new WaitForSeconds(interval);
        }
    
    }
}

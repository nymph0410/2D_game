using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DiaLogueSysteam : MonoBehaviour
{
    [Header("��ܶ��j"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("�e����ܨt��")]
    public GameObject goDialogue;
    [Header("��ܤ��e")]
    public Text textContent;
    [Header("��ܧ����ϥ�")]
    public GameObject goTip;
    [Header("��ܫ���")]
    public KeyCode keyDialogue = KeyCode.Mouse0;

    private void Start()
    {
       // StartCoroutine(TypeEffect());
    }

    /// <summary>
    /// ���r�ĪG
    /// </summary>
    /// <param name="contents"></param>
    /// <returns></returns>
    private IEnumerator TypeEffect(string[] contents) 
    {
        //string test1 = "���o�A�A�n~";
        //string test2 = "�ڬO�ĤG�q���!";
        //string[] contents = { test1, test2 };

        textContent.text = "";
        goDialogue.SetActive(false);

        for (int j = 0; j < contents.Length; j++)
        {
            for (int i = 0; i < contents[j].Length; i++)
            {
                textContent.text += contents[j][i];
                yield return new WaitForSeconds(interval);
            }

            goTip.SetActive(true);

            while (!Input.GetKeyDown(keyDialogue))
            {
                yield return null;
            }

            goDialogue.SetActive(false);
        }
    }

    /// <summary>
    /// �}�l���
    /// </summary>
    public void StarDialogue(string[] contents) 
    {

        StartCoroutine(TypeEffect(contents));
    
    }

    /// <summary>
    /// ������
    /// </summary>
    public void StopDialogue()
    {
        StopAllCoroutines();
        goDialogue.SetActive(false);
    }
}

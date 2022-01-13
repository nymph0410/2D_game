using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DiaLogueSysteam : MonoBehaviour
{
    [Header("對話間隔"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("畫布對話系統")]
    public GameObject goDialogue;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話完成圖示")]
    public GameObject goTip;
    [Header("對話按鍵")]
    public KeyCode keyDialogue = KeyCode.Mouse0;

    private void Start()
    {
       // StartCoroutine(TypeEffect());
    }

    /// <summary>
    /// 打字效果
    /// </summary>
    /// <param name="contents"></param>
    /// <returns></returns>
    private IEnumerator TypeEffect(string[] contents) 
    {
        //string test1 = "哈囉，你好~";
        //string test2 = "我是第二段對話!";
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
    /// 開始對話
    /// </summary>
    public void StarDialogue(string[] contents) 
    {

        StartCoroutine(TypeEffect(contents));
    
    }

    /// <summary>
    /// 停止對話
    /// </summary>
    public void StopDialogue()
    {
        StopAllCoroutines();
        goDialogue.SetActive(false);
    }
}

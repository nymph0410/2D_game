using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("對話資料")]
    public DataDailogue dataDailogue;
    [Header("對話系統")]
    public DiaLogueSysteam dialogueSysteam;
    [Header("觸發對話的對象")]
    public string target = "小花";
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            dialogueSysteam.StarDialogue(dataDailogue.dislogues);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            dialogueSysteam.StopDialogue();
        }
    }
}

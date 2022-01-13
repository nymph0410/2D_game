using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("��ܸ��")]
    public DataDailogue dataDailogue;
    [Header("��ܨt��")]
    public DiaLogueSysteam dialogueSysteam;
    [Header("Ĳ�o��ܪ���H")]
    public string target = "�p��";
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

using UnityEngine;
/// <summary>
/// ��ܸ��
/// �O�sNPC�n�򪱮a������ܤ��e
/// </summary>

[CreateAssetMenu(menuName = "Hanabi/��ܸ��")]
public class DataDailogue : ScriptableObject
{
    [Header("��ܤ��e"),TextArea(3, 5)]
    public string[] dislogues;
}

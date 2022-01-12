using UnityEngine;
/// <summary>
/// 對話資料
/// 保存NPC要跟玩家說的對話內容
/// </summary>

[CreateAssetMenu(menuName = "Hanabi/對話資料")]
public class DataDailogue : ScriptableObject
{
    [Header("對話內容"),TextArea(3, 5)]
    public string[] dislogues;
}

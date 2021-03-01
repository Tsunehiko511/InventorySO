using System.Collections.Generic;
using UnityEngine;
using System.Collections;

// これとInventoryObjectの違いはなに？
[CreateAssetMenu]
public class ItemDatabaseObject : ScriptableObject
{
    // アイテムのデータベース
    public ItemObject[] items;

    // 今後アイテムが増えたときに, 取得しやすい形にするため？
}

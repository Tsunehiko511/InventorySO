using System.Collections.Generic;
using UnityEngine;
using System.Collections;

// これとInventoryObjectの違いはなに？
[CreateAssetMenu]
public class ItemDatabaseObject : ScriptableObject, ISerializationCallbackReceiver
{
    // アイテムのデータベース
    public ItemObject[] items;

    // GetItemを使って取得を行う
    public Dictionary<int, ItemObject> GetItem = new Dictionary<int, ItemObject>();

    // Deserialize後に実行される(復元したあと辞書型に入れる)
    public void OnAfterDeserialize()
    {
        for (int i=0; i< items.Length; i++)
        {
            items[i].id = i;
            GetItem.Add(i, items[i]);
        }
    }

    // 変換後はリセットする
    public void OnBeforeSerialize()
    {
        GetItem = new Dictionary<int, ItemObject>();
    }
}
/*
 * シリアライズ:オブジェクトかされたデータを文字列などの保存できる形式に変換すること
 * デシリアライズ:シリアライズの逆（文字列などからプログラミングが扱えるオブジェクトの方に復元すること）
 */
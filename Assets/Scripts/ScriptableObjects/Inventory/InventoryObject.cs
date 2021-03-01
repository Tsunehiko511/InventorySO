using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InventoryObject : ScriptableObject
{
    // アイテムを全体管理:関数を持っている
    // ゲーム内で引き出す
    // セーブ&ロード
    const string SAVE_KEY = "SAVE_KEY";
    
    // public ItemDatabaseObject database; // データを引き出すときに使う? なんのために使う？

    public List<InventorySlot> items = new List<InventorySlot>();
    // データセット
    public void AddItem(Item item, int amount)
    {
        for (int i=0; i< items.Count; i++)
        {
            if (items[i].item == item)
            {
                items[i].AddAmount(amount);
                return;
            }
        }
        items.Add(new InventorySlot(item, amount));
    }

    // Save/Load/Clear関係
    [ContextMenu("Save")]
    public void Save()
    {
        Debug.Log("Saveの予定");
        string json = JsonUtility.ToJson(this, true);
        PlayerPrefs.SetString(SAVE_KEY, json);
        Debug.Log(json);
    }

    [ContextMenu("Load")]
    public void Load()
    {
        Debug.Log("Loadの予定");
        if (PlayerPrefs.HasKey(SAVE_KEY))
        {
            
            string json = PlayerPrefs.GetString(SAVE_KEY);
            JsonUtility.FromJsonOverwrite(json, this);

        }
    }
    [ContextMenu("Clear")]
    public void Clear()
    {
        Debug.Log("データClearの予定");
        items.Clear();
    }
}


[Serializable]
public class InventorySlot // Slot:どんなアイテムが何個入っているか
{
    public Item item;
    public int amount;

    public InventorySlot()
    {
        item = null;
        amount = 0;
    }

    public InventorySlot(Item item, int amount)
    {
        this.item = item;
        this.amount = amount;
    }

    public void UpdateSlot(Item item, int amount)
    {
        this.item = item;
        this.amount = amount;
    }


    public void AddAmount(int value)
    {
        amount += value;
    }
}

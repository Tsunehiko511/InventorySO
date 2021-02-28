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

    
    public ItemDatabaseObject database; // データを引き出すときに使う

    public List<InventorySlot> items = new List<InventorySlot>();
    // データセット
    public void AddItem(Item item, int amount)
    {
        for (int i=0; i< items.Count; i++)
        {
            if (items[i].item.id == item.id)
            {
                items[i].AddAmount(amount);
                return;
            }
        }
        items.Add(new InventorySlot(item.id, item, amount));
    }

    // Save/Load/Clear関係
    [ContextMenu("Save")]
    public void Save()
    {
        Debug.Log("Saveの予定");
    }

    [ContextMenu("Load")]
    public void Load()
    {
        Debug.Log("Loadの予定");
    }
    [ContextMenu("Clear")]
    public void Clear()
    {
        Debug.Log("データClearの予定");
        items.Clear();
        items.Clear();
    }
}


[Serializable]
public class InventorySlot // Slot:どんなアイテムが何個入っているか
{
    public int id;
    public Item item;
    public int amount;

    public InventorySlot()
    {
        id = -1;
        item = null;
        amount = 0;
    }

    public InventorySlot(int id, Item item, int amount)
    {
        this.id = id;
        this.item = item;
        this.amount = amount;
    }

    public void UpdateSlot(int id, Item item, int amount)
    {
        this.id = id;
        this.item = item;
        this.amount = amount;
    }


    public void AddAmount(int value)
    {
        amount += value;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Attributes
{
    Agility,
    Intellect,
    Stamina,
    Strength
}

[CreateAssetMenu]
public abstract class ItemObject : ScriptableObject // 容器
{
    public enum ItemType
    {
        Food,
        Equipment,
        Default
    }

    public new string name;
    public ItemType type;
    [TextArea(15, 20)]
    public string description;
    public List<ItemBuff> buffs = new List<ItemBuff>();

    public Item CreateItem()
    {
        return new Item(this);
    }
}

[Serializable]
public class Item // データ（渡す用?）
{
    public string name;
    public List<ItemBuff> buffs = new List<ItemBuff>();
    public Item(ItemObject item)
    {
        name = item.name;
        buffs =  new List<ItemBuff>(item.buffs);

    }
}

[Serializable]
public class ItemBuff
{
    public Attributes attribute;
    public int value;
}
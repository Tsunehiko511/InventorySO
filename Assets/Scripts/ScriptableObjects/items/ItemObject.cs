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

    public int id;
    public ItemType type;
    [TextArea(15, 20)]
    public string description;

    public Item CreateItem()
    {
        return new Item(this);
    }
}

[Serializable]
public class Item // データ（いけ渡す用?）
{
    public string name;
    public int id;
    public Item(ItemObject item)
    {
        name = item.name;
        id = item.id;
    }
}

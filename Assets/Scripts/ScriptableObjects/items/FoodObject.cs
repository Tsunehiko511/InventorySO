using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FoodObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Food;
    }
}
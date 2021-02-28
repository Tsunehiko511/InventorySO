using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DefaultObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Default;
    }
}
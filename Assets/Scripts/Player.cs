using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] InventoryObject inventory = default;
    [SerializeField] GroundItem groundItem = default;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Item item = new Item(groundItem.item);
            inventory.AddItem(item, 2);
        }
    }

    private void OnApplicationQuit()
    {
        inventory.Clear();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] InventoryObject inventory = default;
    [SerializeField] GroundItem[] groundItem = default;
    [SerializeField] InventoryUI inventoryUI = default;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryUI.gameObject.SetActive(true);
            inventoryUI.Show();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Item item = new Item(groundItem[0].item);
            inventory.AddItem(item, 2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Item item = new Item(groundItem[0].item);
                inventory.AddItem(item, 1);
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                Item item = new Item(groundItem[1].item);
                inventory.AddItem(item, 1);
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                Item item = new Item(groundItem[2].item);
                inventory.AddItem(item, 1);
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            inventory.Save();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            inventory.Load();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            inventory.Clear();
        }
    }

    /*
    private void OnApplicationQuit()
    {
        inventory.Clear();
    }
    */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] InventoryObject inventory = default;
    // Text[] itemTexts;
    [SerializeField] Text textPrefab = default;
    // Inventoryを表示する
    public void Show()
    {
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject); 
        }
        // itemTexts = GetComponentsInChildren<Text>();
        foreach (InventorySlot slot in inventory.items)
        {
            Text itemText = Instantiate(textPrefab, transform);
            itemText.text = slot.item.name+"x"+slot.amount;
        }
    }

}

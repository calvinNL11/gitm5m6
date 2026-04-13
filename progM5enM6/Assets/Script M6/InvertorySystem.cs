using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    private List<InventoryItem> _inventory = new List<InventoryItem>();

    [SerializeField] private int _guns = 2;
    [SerializeField] private int _medipacks = 4;
    [SerializeField] private int _keycards = 1;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G)) ToggleGun();
        if (Input.GetKeyDown(KeyCode.M)) ToggleMedipack();
        if (Input.GetKeyDown(KeyCode.K)) ToggleKeycard();
    }

    public void ToggleGun()
    {
        ToggleItem<GunItem>(ref _guns);
    }

    public void ToggleMedipack()
    {
        ToggleItem<MedipackItem>(ref _medipacks);
    }

    public void ToggleKeycard()
    {
        ToggleItem<KeycardItem>(ref _keycards);
    }

    private void ToggleItem<T>(ref int worldCount) where T : InventoryItem, new()
    {
        InventoryItem item = _inventory.Find(i => i is T);

        if (item != null)
        {
            _inventory.Remove(item);
            worldCount++;
            Debug.Log($"Dropped {item.ItemName}");
        }
        else if (worldCount > 0)
        {
            _inventory.Add(new T());
            worldCount--;
            Debug.Log($"Picked up {typeof(T).Name}");
        }

        ShowStatus();

        /*holy koppijn*/

        /*holy koppijn*/

    }

    private int Count<T>() where T : InventoryItem
    {
        int count = 0;

        foreach (var item in _inventory)
        {
            if (item is T)
                count++;
        }

        return count;
    }

    private void ShowStatus()
    {
        Debug.Log(
            $"World: G={_guns} M={_medipacks} K={_keycards} | " +
            $"Inventory: G={Count<GunItem>()} M={Count<MedipackItem>()} K={Count<KeycardItem>()}"
        );

      
    }
}

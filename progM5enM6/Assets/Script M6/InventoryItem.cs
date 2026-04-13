using UnityEngine;

public class InventoryItem
{
    public string ItemName { get; private set; }

    public InventoryItem(string itemName)
    {
        ItemName = itemName;
    }
}

public class GunItem : InventoryItem
{
    public GunItem() : base("Gun") { }
}

public class MedipackItem : InventoryItem
{
    public MedipackItem() : base("Medipack") { }
}

public class KeycardItem : InventoryItem
{
    public KeycardItem() : base("Keycard") { }
}
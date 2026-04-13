using UnityEngine;

public class CoinPickup : Collectable
{
    [SerializeField] private int _coinAmount = 10;
    public override void OnCollect()
    {
        Debug.Log(_coinAmount + " Coins collected!");
        GetCollectableCount();
        Destroy(gameObject);
    }
}

using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 100;

    // Delegate declareren
    public Action onCoinCollected;

    public static event Action<int> CoinCollected;

    public void OnTriggerEnter()
    {
        CoinCollected?.Invoke(coinValue);
        Destroy(gameObject);
    }
}


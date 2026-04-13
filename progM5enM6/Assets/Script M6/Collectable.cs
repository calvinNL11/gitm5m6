using System.Collections.Generic;
using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    private void Start()
    {
        GetCollectableCount();
    }

    public abstract void OnCollect();

    private void OnTriggerEnter(Collider other)
    {
        OnCollect();
    }

    public void GetCollectableCount()
    {
        Collectable[] collectables = FindObjectsByType<Collectable>(FindObjectsSortMode.None);
        Debug.Log("Collectible collected! Remaining: " + collectables.Length);
    }

}

using UnityEngine;

public class HealthPickup : Collectable
{
    [SerializeField] private int _healthAmount = 20;
    public override void OnCollect()
    {
        Debug.Log(_healthAmount + " Health restored!");
        GetCollectableCount();
        Destroy(gameObject);
    }
}

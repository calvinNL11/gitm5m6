using UnityEngine;

public class DamageTrap : Collectable
{
    [SerializeField] private int _damageAmount = 5;
    public override void OnCollect()
    {
        Debug.Log(_damageAmount + " Damage taken!");
        Debug.Log("BOOM!");
        GetCollectableCount();
        Destroy(gameObject);
    }
}

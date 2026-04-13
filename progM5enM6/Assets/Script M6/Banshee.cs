using UnityEngine;

public class Banshee : Enemy
{

    private void Start()
    {
        gameObject.name = "Banshee";
    }
    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage); // Gewone damage berekening
        if (health <= 50)
        {
            Flee();
        }
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"banshee raakt {target.name}!");
    }

    private void Flee()
    {
        Debug.Log($"{gameObject.name} is weg gerend!");
    }
}

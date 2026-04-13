using UnityEngine;

public class EnemyM6 : MonoBehaviour
{
    void Update()
    {
        Vector3 pos = transform.position;
        pos.z += 1f * Time.deltaTime;
        transform.position = pos;
    }
}
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [System.Serializable]
    public struct SpawnablesData
    {
        public GameObject _prefab;
        public int _count;
    }

    [SerializeField] private List<SpawnablesData> spawnables;

    void Start()
    {
        foreach (var spawn in spawnables)
        {
            for (int i = 0; i <= spawn._count; i++)
            {   
                Instantiate(spawn._prefab, new Vector3(Random.Range(-8f, 8f), 1, Random.Range(-8f, 8f)), Quaternion.identity);
            }
        }

    }

}

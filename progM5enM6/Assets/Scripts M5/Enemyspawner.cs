using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> enemies = new List<GameObject>();
    [SerializeField] private GameObject enemyPrefab;

    private float timer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                enemies.Add(Instantiate(enemyPrefab));
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            for (int i = 0; i < enemies.Count; i++)
            {
                Destroy(enemies[i]);
            }
        }

        timer += Time.deltaTime;

        if (timer > 1f)
        {
            timer = 0f;
            enemies.Add(Instantiate(enemyPrefab));
        }
    }
}

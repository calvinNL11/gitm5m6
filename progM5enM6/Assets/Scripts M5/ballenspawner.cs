using System.Collections.Generic;
using UnityEngine;

public class ballenspawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public List<GameObject> enemies = new List<GameObject>();
    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            timer = 0f;
            Spawn3Enemies();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Spawn100Enemies();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            RemoveAllEnemies();
        }
    }

    void Spawn100Enemies()
    {
        for (int i = 0; i < 100; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-5f, 5f),
                0,
                Random.Range(-5f, 5f)
            );
            GameObject newEnemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            enemies.Add(newEnemy);
        }
    }

    void RemoveAllEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();
    }

    void Spawn3Enemies()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-5f, 5f),
                0,
                Random.Range(-5f, 5f)
    );
            GameObject newEnemy = Instantiate(enemyPrefab, randomPosition, Quaternion.identity);
            enemies.Add(newEnemy);
        }
    }
}
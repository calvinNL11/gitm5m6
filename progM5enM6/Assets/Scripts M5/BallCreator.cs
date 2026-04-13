using UnityEngine;

public class BallCreator : MonoBehaviour
{
    [Header("Ball Settings")]
    public GameObject prefab;
    public Material ballMaterial;
    public float destroyTime = 3f;
    private float elapsedTime = 0f;
    

 

    private GameObject CreateBall(Color color, Vector3 position)
    {
        GameObject ball = Instantiate(prefab, position, Quaternion.identity);

        MeshRenderer renderer = ball.GetComponent<MeshRenderer>();
        if (renderer != null)
        {
            ApplyColorToMaterial(renderer.material, color);
        }
        return ball;
    }
    private void DestroyBall(GameObject ballToDestroy)
    {
        Destroy(ballToDestroy, destroyTime);
    }
    private void ApplyColorToMaterial(Material material, Color color)
    {
        if (material.shader.name == "Universal Render Pipeline/Lit")
        {
            material.SetColor("_BaseColor", color);
        }
        else
        {
            material.SetColor("_Color", color);
        }
    }
    private Color GenerateRandomColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        float a = 1f;

        return new Color(r, g, b, a);
    }
    private Vector3 GenerateRandomPosition(float min, float max)
    {
        float x = Random.Range(min, max);
        float y = Random.Range(5f, 10f);
        float z = Random.Range(min, max);

        return new Vector3(x, y, z);
    }
    private void Start()
    {
        Debug.Log("Start: Maak 100 ballen aan");
        for (int i = 0; i < 100; i++)
        {
            Color randomColor = GenerateRandomColor();
            Vector3 randomPosition = GenerateRandomPosition(-10f, 10f);

            GameObject newBall = CreateBall(randomColor, randomPosition);

            DestroyBall(newBall);
            if (i % 20 == 0)
            {
                Debug.Log($"Aangemaakt: {i + 1}/100 ballen");
            }
        }

        Debug.Log("done met het maken van 100 ballen");
    }
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Color color = GenerateRandomColor();
            Vector3 randPos = GenerateRandomPosition(-10f, 10f);
            GameObject ball = CreateBall(color, randPos);
            DestroyBall(ball);
            elapsedTime = 0f;

        }
    }
}


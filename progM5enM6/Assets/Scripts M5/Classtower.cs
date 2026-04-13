using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randimsize = Random.Range(0f, 2.0f);
        Vector3 newsize = new Vector3(randimsize, randimsize, randimsize);
        transform.localScale = newsize;

    }

    // Update is called once per frame
    void Update()
    {

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemigoPrefab;
    public float spawnRate = 1.5f;

    float minX;
    float maxX;

    void Start()
    {

        Vector3 leftLimit = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 rightLimit = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));

        minX = leftLimit.x + 0.5f; 
        maxX = rightLimit.x - 0.5f;

        InvokeRepeating("SpawnEnemy", 1f, spawnRate);
    }

    void SpawnEnemy()
    {
        float x = Random.Range(minX, maxX);

        Vector2 pos = new Vector2(x, transform.position.y);

        Instantiate(enemigoPrefab, pos, Quaternion.identity);
    }
}

using System.Collections;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject fallingObjectPrefab;
    public GameObject badObjectPrefab;
    public float spawnRangeX = 8f;
    public float spawnDelay = 1.5f;
    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            float randomSpawn = Random.Range(0, 2);
            float randomX = Random.Range(-spawnRangeX, spawnRangeX);
            Vector3 spawnPosition = new Vector3(randomX, 8, 0);

            if(randomSpawn == 0)
            {
                Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
            }
            else if(randomSpawn == 1)
            {
                Instantiate(badObjectPrefab, spawnPosition, Quaternion.identity);
            }
            yield return new WaitForSeconds(spawnDelay);

            spawnDelay = Mathf.Max(0.3f, spawnDelay - 0.03f);
        }
    }
}

using System.Collections;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnDelay = 3f;
    public Transform player;
    public float spawnOffsetX = 15f;
    public LayerMask groundLayer;
    public float heightAboveGround = 0.5f;
    public float rayStartHeight = 50f;
    public float rayDistance = 100f;
    public float spawnY;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }
    IEnumerator SpawnLoop()
    {
        while (true)
        {
            float spawnX = player.position.x + spawnOffsetX;

            RaycastHit2D hit = Physics2D.Raycast(new Vector2(spawnX, rayStartHeight), Vector2.down, rayDistance, groundLayer);

            if(hit.collider != null)
            {
             spawnY = hit.point.y + heightAboveGround;
             Vector3 spawnPotion = new Vector3(spawnX, spawnY, 0);
             Instantiate(obstaclePrefab, spawnPotion, Quaternion.identity);
            }
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}

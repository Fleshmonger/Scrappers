using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    private int waveIndex = 0, spawnIndex;
    public Wave[] waves;
    public Vector3[] spawnPoints;

    // Update is called once per frame
    private void Update()
    {
        if (waveIndex < waves.Length)
        {
            Wave wave = waves[waveIndex];
            Unit unitPrefab = wave.unitPrefabs[spawnIndex];
            CircleCollider2D collider2D = unitPrefab.GetComponent<CircleCollider2D>();
            if (!collider2D || !Physics2D.OverlapCircle(spawnPoints[0], collider2D.radius))
            {
                Spawn(unitPrefab, spawnPoints[0]);
                spawnIndex++;
                if (spawnIndex >= wave.unitPrefabs.Length)
                {
                    spawnIndex = 0;
                    waveIndex++;
                }
            }
        }
    }

    // Spawns the given unit.
    private void Spawn(Unit unitPrefab, Vector3 position)
    {
        Instantiate(unitPrefab, position, Quaternion.identity);
    }
}

using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public GameObject[] enemies; // array dei nemici classici
    public GameObject[] strongEnemies; // array dei nemici più forti
    public int wavesBeforeStrongEnemy = 3; // ogni quanti wave spawnare un nemico più forte
    public float timeBetweenWaves = 5f; // tempo tra una wave e l'altra
    public Transform[] spawnPoints; // array dei punti di spawn dei nemici

    public Transform[] Waypoints;
    private int waveNumber = 0;

    void Start()
    {
        StartCoroutine(SpawnWave());
    }

    IEnumerator SpawnWave()
    {
        while (true)
        {
            waveNumber++;
            Debug.Log("Wave " + waveNumber + " incoming!");

            for (int i = 0; i < waveNumber; i++)
            {
                SpawnEnemy(enemies[Random.Range(0, enemies.Length)]);
                yield return new WaitForSeconds(0.5f);
            }


            if (waveNumber % wavesBeforeStrongEnemy == 0)
            {
                SpawnEnemy(strongEnemies[Random.Range(0, strongEnemies.Length)]);
            }

            GameManager.instance.AddMoney(100);
            yield return new WaitForSeconds(timeBetweenWaves);
            
        }
        
    }

    void SpawnEnemy(GameObject enemy)
    {
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        GameObject newEnemy = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        EnemyAI enemyAI = newEnemy.GetComponent<EnemyAI>();
        enemyAI.Waypoints = Waypoints;
    }
}
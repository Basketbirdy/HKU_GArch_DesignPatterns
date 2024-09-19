using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    GameObjectPool enemyPool;

    [SerializeField] private GameObject enemyPrefab;

    private int enemyCount;

    private void OnEnable()
    {
        EventSystem<Wave>.AddListener(EventType.WAVE_START, SpawnWave);
    }

    private void OnDisable()
    {
        EventSystem<Wave>.RemoveListener(EventType.WAVE_START, SpawnWave);
    }

    private void Start()
    {
        enemyPool = new GameObjectPool(enemyPrefab, 25);
    }

    private void SpawnWave(Wave wave)
    {
        float interval = 1 * wave.waveInfo.GetSpawnInterval();

        //foreach(EnemyBase enemy in wave.enemies) 
        //{
        //    GameObject enemyObj = enemyPool.AcquireObject();

        //    InitializeEnemy(enemyObj, Vector3.zero, Quaternion.identity);
        //}
    }

    private void InitializeEnemy(GameObject enemy, Vector3 position, Quaternion rotation)
    {
        // set enemy to the correct enemy type

        // reset enemy
        enemy.transform.position = position;
        enemy.transform.rotation = rotation;

        // enable enemy
        enemy.SetActive(true);
    }
}

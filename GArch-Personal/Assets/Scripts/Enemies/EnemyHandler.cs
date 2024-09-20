using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    public static Type[] possibleEnemies;

    [SerializeField] private SpawnPoint[] spawnPoints;
    [SerializeField] private GameObject enemyPrefab;

    private GameObjectPool enemyPool;   
    private int enemyCount = 0;         // keep track of the amount of enemies active

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
        possibleEnemies = new Type[] 
        {
            typeof(EnemyArcher),
            typeof(EnemyTower),
            typeof(EnemySteelRam)
        };

        enemyPool = new GameObjectPool(enemyPrefab, 25);
    }

    private void Update()
    {
        // trigger wave for the first time
        if (Input.GetKeyDown(KeyCode.E))
        {
            EventSystem<int>.InvokeEvent(EventType.WAVE_END, 0);
        }
    }

    private void SpawnWave(Wave _wave)
    {
        Debug.Log("[EnemyHandler] Received WAVE_START event with:" + _wave);
        DebugWaveInfo(_wave);

        float interval = 1 * _wave.waveInfo.GetSpawnInterval();

        foreach(GroupInfo group in _wave.waveInfo.GetGroupInfo())
        {
            // log all the group info
            Debug.Log("[EnemyHandler] Spawned new group");
            Debug.Log("[EnemyHandler] Enemy type: " + group.enemyType.ToString());
            Debug.Log("[EnemyHandler] Group shape: " + group.shape.ToString());
            Debug.Log("[EnemyHandler] Spawn direction: " + group.direction.ToString());

            // get spawn location
            Transform spawnPoint = null;
            foreach (SpawnPoint sp in spawnPoints)
            {
                if (group.direction != sp.direction) { continue; }

                spawnPoint = sp.transforms[UnityEngine.Random.Range(0, sp.transforms.Length)];
            }

            // object pools a single enemy, should be multiple depending on pattern
            GameObject newEnemyGroup = enemyPool.AcquireObject();
            enemyCount++;
            InitializeEnemy(newEnemyGroup, group, spawnPoint.position, Quaternion.identity);

            StartCoroutine(Interval(interval));
        }
    }

    private void InitializeEnemy(GameObject _enemy, GroupInfo _groupInfo, Vector3 _position, Quaternion _rotation)
    {
        if(_enemy == null) { return; }

        // set enemy to the correct enemy type
        _enemy.GetComponent<IEnemy>().Setup(_groupInfo.enemyType);

        // reset enemy
        _enemy.transform.position = _position;
        _enemy.transform.rotation = _rotation;

        // enable enemy
        _enemy.SetActive(true);
    }

    private IEnumerator Interval(float interval)
    {
        yield return new WaitForSeconds(interval);
    }

    private void DebugWaveInfo(Wave _wave)
    {
        Debug.Log("[Wave] SpawnInterval: ");
        Debug.Log("[Wave] " + _wave.waveInfo.GetSpawnInterval().ToString());

        List<GroupInfo> shapes = _wave.waveInfo.GetGroupInfo();
        Debug.Log("[Wave] Spawn Shapes: ");
        if (shapes.Count == 0) { Debug.Log("[Wave] -"); }
        foreach (GroupInfo shapeInfo in shapes)
        {
            Debug.Log("[Wave] Shape: " + shapeInfo.shape.ToString() + "; Direction: " + shapeInfo.direction.ToString());
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
{
    private EnemyBase enemyDefinition;

    private void Start()
    {
        // enemy logic
    }

    private void Update()
    {
        // enemy logic
    }

    public void Setup(EnemyBase _enemyDefinition)
    {
        enemyDefinition = _enemyDefinition;
        Debug.Log("[Enemy]: " +  enemyDefinition);
    }
}

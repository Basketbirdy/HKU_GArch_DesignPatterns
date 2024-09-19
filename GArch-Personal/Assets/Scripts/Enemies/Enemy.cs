using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy
{
    private EnemyBase enemyDefinition;
    
    public void Setup(EnemyBase enemyDefinition)
    {
        this.enemyDefinition = enemyDefinition;
        Debug.Log("[Enemy]: " +  this.enemyDefinition);
    }
}

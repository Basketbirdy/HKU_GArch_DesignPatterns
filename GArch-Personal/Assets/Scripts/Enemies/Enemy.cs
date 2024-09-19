using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    EnemyBase enemyDefinition;
    
    public void EnemySetup(EnemyBase enemyDefinition)
    {
        this.enemyDefinition = enemyDefinition;
    }
}

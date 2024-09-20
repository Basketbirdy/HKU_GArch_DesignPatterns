using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction 
{
    NORTH = 0,
    EAST = 1,
    SOUTH = 2,
    WEST = 3
}
public enum Shape 
{ 
    DOT = 0,
    CIRCLE = 1,
    SQUARE = 2,
    FILLED_SQUARE = 3,
    STAR = 4,
    ARROW = 5
}

public class GroupInfo
{
    public Shape shape;
    public Direction direction;
    public EnemyBase enemyType;

    public GroupInfo(Shape _shape)
    {
        shape = _shape;
        direction = GetDirection();
        enemyType = GetEnemyType();
    }

    private Direction GetDirection()
    {
        int value = UnityEngine.Random.Range(0, 5);

        switch(value)
        {
            case 1: return Direction.NORTH;
            case 2: return Direction.SOUTH;
            case 3: return Direction.WEST;
            case 4: return Direction.EAST;
        }

        return Direction.NORTH;
    }

    private EnemyBase GetEnemyType()
    {
        int randEnemy = UnityEngine.Random.Range(0, EnemyHandler.possibleEnemies.Length);
        return (EnemyBase)Activator.CreateInstance(EnemyHandler.possibleEnemies[randEnemy]);
    }
}

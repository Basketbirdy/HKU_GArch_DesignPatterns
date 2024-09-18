using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction { NORTH, EAST, SOUTH, WEST }
public enum Shape { DOT, CIRCLE, SQUARE, FILLED_SQUARE, STAR, ARROW }

public class ShapeInfo
{
    public Shape shape;
    public Direction direction;

    public ShapeInfo(Shape shape)
    {
        this.shape = shape;
        this.direction = GetDirection();
    }

    private Direction GetDirection()
    {
        int value = Random.Range(0, 5);

        switch(value)
        {
            case 1: return Direction.NORTH;
            case 2: return Direction.SOUTH;
            case 3: return Direction.WEST;
            case 4: return Direction.EAST;
        }

        return Direction.NORTH;
    }
}

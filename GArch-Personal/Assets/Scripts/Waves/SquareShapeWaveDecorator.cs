using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareShapeWaveDecorator : IWaveInfo
{
    IWaveInfo waveInfo;

    public SquareShapeWaveDecorator(IWaveInfo waveInfo)
    {
        this.waveInfo = waveInfo;
    }

    public List<ShapeInfo> GetShapeInfo()
    {
        List<ShapeInfo> decoratedShapes = waveInfo.GetShapeInfo();
        decoratedShapes.Add(new ShapeInfo(Shape.SQUARE));
        return decoratedShapes;
    }

    public float GetSpawnInterval()
    {
        return waveInfo.GetSpawnInterval();
    }
}

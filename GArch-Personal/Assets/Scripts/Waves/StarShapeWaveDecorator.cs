using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarShapeWaveDecorator : IWaveInfo
{
    IWaveInfo waveInfo;

    public StarShapeWaveDecorator(IWaveInfo waveInfo)
    {
        this.waveInfo = waveInfo;
    }

    public List<ShapeInfo> GetShapeInfo()
    {
        List<ShapeInfo> decoratedShapes = waveInfo.GetShapeInfo();
        decoratedShapes.Add(new ShapeInfo(Shape.STAR));
        return decoratedShapes;
    }

    public float GetSpawnInterval()
    {
        return waveInfo.GetSpawnInterval();
    }
}

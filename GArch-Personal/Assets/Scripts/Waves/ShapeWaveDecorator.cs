using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeWaveDecorator : IWaveInfo
{
    private IWaveInfo waveInfo;
    private ShapeInfo waveShapeInfo;


    public ShapeWaveDecorator(IWaveInfo waveInfo, ShapeInfo waveShapeInfo)
    {
        this.waveInfo = waveInfo;
        this.waveShapeInfo = waveShapeInfo;
    }

    public List<ShapeInfo> GetShapeInfo()
    {
        List<ShapeInfo> decoratedShapes = waveInfo.GetShapeInfo();
        decoratedShapes.Add(waveShapeInfo);
        return decoratedShapes;
    }

    public float GetSpawnInterval()
    {
        return waveInfo.GetSpawnInterval();
    }
}
